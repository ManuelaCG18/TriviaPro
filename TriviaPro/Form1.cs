using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaPro
{
    public partial class Form1: Form
    {
        private Jugador jugador;
        private List<Pregunta> preguntasRespondidas = new List<Pregunta>();
        private Pregunta preguntaActual;
        private int preguntasRestantes = 15;
        private int tiempoRestante;

        private const int TIEMPO_FACIL = 20;
        private const int TIEMPO_MEDIO = 15;
        private const int TIEMPO_DIFICIL = 10;

        public Form1()
        {
            InitializeComponent();
            jugador = new Jugador();
            ConfigurarInterfaz();
        }

        private void ConfigurarInterfaz()
        {
            // Configurar ListView
            listViewPreguntas.View = View.Details;
            listViewPreguntas.Columns.Add("Pregunta", 300);
            listViewPreguntas.Columns.Add("Tu respuesta", 150);
            listViewPreguntas.Columns.Add("Correcta", 80);
            listViewPreguntas.Columns.Add("Puntos", 60);
            listViewPreguntas.FullRowSelect = true;

            // Configurar Timer
            timerPregunta.Interval = 1000; // 1 segundo
            timerPregunta.Tick += timerPregunta_Tick;

            // Configurar ComboBoxes
            cmbCategoria.Items.AddRange(new[] { "Ciencia", "Historia", "Cultura General" });
            cmbNivel.Items.AddRange(new[] { "Facil", "Medio", "Dificil" });

            // Estilo del Panel de opciones
            panelOpciones.AutoScroll = true;
            panelOpciones.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem == null || cmbNivel.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar categoría y nivel", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IniciarNuevoJuego();
        }

        private void IniciarNuevoJuego()
        {
            jugador.Reiniciar();
            preguntasRespondidas.Clear();
            preguntasRestantes = 15;
            listViewPreguntas.Items.Clear();
            panelOpciones.Controls.Clear();
            progressBarTiempo.ForeColor = SystemColors.Highlight;
            ActualizarUI();
            MostrarNuevaPregunta();
        }

        private void MostrarNuevaPregunta()
        {
            if(preguntasRestantes <= 0)
            {
                FinalizarJuego();
                return;
            }

            try
            {
                preguntaActual = PreguntaFactory.CrearPregunta(cmbCategoria.SelectedItem.ToString(), cmbNivel.SelectedItem.ToString());

                lblPregunta.Text = preguntaActual.Texto;
                CargarOpcionesDeRespuesta();
                IniciarTemporizador(cmbNivel.SelectedItem.ToString());

                preguntasRestantes--;
                lblPreguntasRestantes.Text = $"Preguntas restantes: {preguntasRestantes}";
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pregunta: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarOpcionesDeRespuesta()
        {
            panelOpciones.Controls.Clear();
            
            if(preguntaActual?.Opciones == null) return;

            int posicionY = 10;
            for (int i = 0; i < preguntaActual.Opciones.Count; i++)
            {
                RadioButton rb = new RadioButton
                {
                    Text = preguntaActual.Opciones[i],
                    Tag = i,
                    AutoSize = true,
                    Location = new Point(10, posicionY),
                    Font = new Font("Segoe UI", 11),
                    Margin = new Padding(5)
                };
                panelOpciones.Controls.Add(rb);
                posicionY += 35;
            }
        }

        private void IniciarTemporizador(string nivel)
        {
            switch (nivel)
            {
                case "Facil":
                    tiempoRestante = TIEMPO_FACIL;
                    break;
                case "Medio":
                    tiempoRestante = TIEMPO_MEDIO;
                    break;
                case "Dificil":
                    tiempoRestante = TIEMPO_DIFICIL;
                    break;
                default:
                    tiempoRestante = 15; // Valor por defecto
                    break;
            }

            progressBarTiempo.Maximum = tiempoRestante;
            progressBarTiempo.Value = tiempoRestante;
            lblTiempo.Text = $"Tiempo: {tiempoRestante}s";
            timerPregunta.Start();
        }

        private void timerPregunta_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            progressBarTiempo.Value = tiempoRestante;
            lblTiempo.Text = $"Tiempo: {tiempoRestante}s";

            if(tiempoRestante < 5)
            {
                progressBarTiempo.ForeColor = Color.Red;
                if(tiempoRestante == 4) SystemSounds.Exclamation.Play();
            }

            if(tiempoRestante <= 0)
            {
                timerPregunta.Stop();
                ProcesarRespuesta(-1);
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            int respuestaSeleccionada = -1;

            foreach (Control control in panelOpciones.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    respuestaSeleccionada = (int)rb.Tag;
                    break;
                }
            }

            if (respuestaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione una opción", "Aviso",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            timerPregunta.Stop();
            ProcesarRespuesta(respuestaSeleccionada);
        }

        private void ProcesarRespuesta(int respuesta)
        {
            bool esCorrecta = preguntaActual.EvaluarRespuesta(respuesta);
            int puntos = esCorrecta ? preguntaActual.PuntajeCorrecto : preguntaActual.PuntajeIncorrecto;
            jugador.ActualizarPuntaje(puntos);
            preguntasRespondidas.Add(preguntaActual);

            // Agregar al ListView
            var item = new ListViewItem(preguntaActual.Texto);
            item.SubItems.Add(preguntaActual.Opciones[respuesta]);
            item.SubItems.Add(esCorrecta ? "Sí" : "No");
            item.SubItems.Add(puntos.ToString());

            // Color de fondo según si fue correcta
            item.BackColor = esCorrecta ? Color.LightGreen : Color.LightPink;

            listViewPreguntas.Items.Add(item);
            item.EnsureVisible(); // Scroll automático

            // Retroalimentación
            string mensaje = esCorrecta ? "¡Correcto!" :
                $"Incorrecto. La respuesta correcta era: {preguntaActual.Opciones[preguntaActual.RespuestaCorrecta]}";

            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK,
                          esCorrecta ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            ActualizarUI();
            MostrarNuevaPregunta();
        }

        private void ActualizarUI()
        {
            lblPuntaje.Text = $"Puntaje: {jugador.Puntaje}";
            lblCorrectas.Text = $"Correctas: {jugador.PreguntasCorrectas}";
            lblIncorrectas.Text = $"Incorrectas: {jugador.PreguntasIncorrectas}";
        }

        private void FinalizarJuego()
        {
            timerPregunta.Stop();
            string resumen = $"Juego terminado!\n\n" +
                             $"Puntaje final: {jugador.Puntaje}\n" +
                             $"Preguntas correctas: {jugador.PreguntasCorrectas}\n" +
                             $"Preguntas incorrectas: {jugador.PreguntasIncorrectas}";

            MessageBox.Show(resumen, "Resumen del Juego",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            IniciarNuevoJuego();
        }
    }
}
