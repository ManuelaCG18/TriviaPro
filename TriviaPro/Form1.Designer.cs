namespace TriviaPro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.timerPregunta = new System.Windows.Forms.Timer(this.components);
            this.progressBarTiempo = new System.Windows.Forms.ProgressBar();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.listViewPreguntas = new System.Windows.Forms.ListView();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblCorrectas = new System.Windows.Forms.Label();
            this.lblIncorrectas = new System.Windows.Forms.Label();
            this.lblPreguntasRestantes = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbCategoria.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.cmbCategoria.FormattingEnabled = true;
            resources.ApplyResources(this.cmbCategoria, "cmbCategoria");
            this.cmbCategoria.Name = "cmbCategoria";
            // 
            // lblPregunta
            // 
            resources.ApplyResources(this.lblPregunta, "lblPregunta");
            this.lblPregunta.ForeColor = System.Drawing.Color.Crimson;
            this.lblPregunta.Name = "lblPregunta";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.ForeColor = System.Drawing.Color.Crimson;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.ForeColor = System.Drawing.Color.Crimson;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.ForeColor = System.Drawing.Color.Crimson;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            resources.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.ForeColor = System.Drawing.Color.Crimson;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // timerPregunta
            // 
            this.timerPregunta.Interval = 1000;
            this.timerPregunta.Tick += new System.EventHandler(this.timerPregunta_Tick);
            // 
            // progressBarTiempo
            // 
            resources.ApplyResources(this.progressBarTiempo, "progressBarTiempo");
            this.progressBarTiempo.Name = "progressBarTiempo";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnIniciar, "btnIniciar");
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // listViewPreguntas
            // 
            this.listViewPreguntas.ForeColor = System.Drawing.Color.Crimson;
            this.listViewPreguntas.HideSelection = false;
            resources.ApplyResources(this.listViewPreguntas, "listViewPreguntas");
            this.listViewPreguntas.Name = "listViewPreguntas";
            this.listViewPreguntas.UseCompatibleStateImageBehavior = false;
            // 
            // cmbNivel
            // 
            this.cmbNivel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbNivel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.cmbNivel.FormattingEnabled = true;
            resources.ApplyResources(this.cmbNivel, "cmbNivel");
            this.cmbNivel.Name = "cmbNivel";
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.btnResponder, "btnResponder");
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.UseVisualStyleBackColor = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.btnReiniciar, "btnReiniciar");
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblPuntaje
            // 
            resources.ApplyResources(this.lblPuntaje, "lblPuntaje");
            this.lblPuntaje.ForeColor = System.Drawing.Color.DeepPink;
            this.lblPuntaje.Name = "lblPuntaje";
            // 
            // lblCorrectas
            // 
            resources.ApplyResources(this.lblCorrectas, "lblCorrectas");
            this.lblCorrectas.ForeColor = System.Drawing.Color.DeepPink;
            this.lblCorrectas.Name = "lblCorrectas";
            // 
            // lblIncorrectas
            // 
            resources.ApplyResources(this.lblIncorrectas, "lblIncorrectas");
            this.lblIncorrectas.ForeColor = System.Drawing.Color.DeepPink;
            this.lblIncorrectas.Name = "lblIncorrectas";
            // 
            // lblPreguntasRestantes
            // 
            resources.ApplyResources(this.lblPreguntasRestantes, "lblPreguntasRestantes");
            this.lblPreguntasRestantes.ForeColor = System.Drawing.Color.DeepPink;
            this.lblPreguntasRestantes.Name = "lblPreguntasRestantes";
            // 
            // lblTiempo
            // 
            resources.ApplyResources(this.lblTiempo, "lblTiempo");
            this.lblTiempo.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTiempo.Name = "lblTiempo";
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.radioButton4);
            this.panelOpciones.Controls.Add(this.radioButton3);
            this.panelOpciones.Controls.Add(this.radioButton2);
            this.panelOpciones.Controls.Add(this.radioButton1);
            resources.ApplyResources(this.panelOpciones, "panelOpciones");
            this.panelOpciones.Name = "panelOpciones";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPreguntasRestantes);
            this.Controls.Add(this.lblIncorrectas);
            this.Controls.Add(this.lblCorrectas);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.listViewPreguntas);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.progressBarTiempo);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.cmbCategoria);
            this.Name = "Form1";
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Timer timerPregunta;
        private System.Windows.Forms.ProgressBar progressBarTiempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ListView listViewPreguntas;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblCorrectas;
        private System.Windows.Forms.Label lblIncorrectas;
        private System.Windows.Forms.Label lblPreguntasRestantes;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Label label1;
    }
}

