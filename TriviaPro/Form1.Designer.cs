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
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(133, 31);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 28);
            this.cmbCategoria.TabIndex = 0;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(44, 139);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(51, 20);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "label1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(83, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(83, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(83, 99);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 24);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(83, 143);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(126, 24);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // timerPregunta
            // 
            this.timerPregunta.Interval = 1000;
            this.timerPregunta.Tick += new System.EventHandler(this.timerPregunta_Tick);
            // 
            // progressBarTiempo
            // 
            this.progressBarTiempo.Location = new System.Drawing.Point(437, 52);
            this.progressBarTiempo.Name = "progressBarTiempo";
            this.progressBarTiempo.Size = new System.Drawing.Size(100, 23);
            this.progressBarTiempo.TabIndex = 6;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(382, 154);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(142, 43);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // listViewPreguntas
            // 
            this.listViewPreguntas.HideSelection = false;
            this.listViewPreguntas.Location = new System.Drawing.Point(661, 114);
            this.listViewPreguntas.Name = "listViewPreguntas";
            this.listViewPreguntas.Size = new System.Drawing.Size(498, 291);
            this.listViewPreguntas.TabIndex = 8;
            this.listViewPreguntas.UseCompatibleStateImageBehavior = false;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(133, 89);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 28);
            this.cmbNivel.TabIndex = 9;
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(382, 220);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(142, 43);
            this.btnResponder.TabIndex = 10;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(382, 292);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(142, 43);
            this.btnReiniciar.TabIndex = 11;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(30, 397);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(51, 20);
            this.lblPuntaje.TabIndex = 12;
            this.lblPuntaje.Text = "label1";
            // 
            // lblCorrectas
            // 
            this.lblCorrectas.AutoSize = true;
            this.lblCorrectas.Location = new System.Drawing.Point(30, 439);
            this.lblCorrectas.Name = "lblCorrectas";
            this.lblCorrectas.Size = new System.Drawing.Size(51, 20);
            this.lblCorrectas.TabIndex = 13;
            this.lblCorrectas.Text = "label1";
            // 
            // lblIncorrectas
            // 
            this.lblIncorrectas.AutoSize = true;
            this.lblIncorrectas.Location = new System.Drawing.Point(30, 479);
            this.lblIncorrectas.Name = "lblIncorrectas";
            this.lblIncorrectas.Size = new System.Drawing.Size(51, 20);
            this.lblIncorrectas.TabIndex = 14;
            this.lblIncorrectas.Text = "label1";
            // 
            // lblPreguntasRestantes
            // 
            this.lblPreguntasRestantes.AutoSize = true;
            this.lblPreguntasRestantes.Location = new System.Drawing.Point(355, 397);
            this.lblPreguntasRestantes.Name = "lblPreguntasRestantes";
            this.lblPreguntasRestantes.Size = new System.Drawing.Size(51, 20);
            this.lblPreguntasRestantes.TabIndex = 15;
            this.lblPreguntasRestantes.Text = "label1";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(355, 439);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(51, 20);
            this.lblTiempo.TabIndex = 16;
            this.lblTiempo.Text = "label1";
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.radioButton4);
            this.panelOpciones.Controls.Add(this.radioButton3);
            this.panelOpciones.Controls.Add(this.radioButton2);
            this.panelOpciones.Controls.Add(this.radioButton1);
            this.panelOpciones.Location = new System.Drawing.Point(45, 168);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(287, 177);
            this.panelOpciones.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 601);
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
            this.Text = "Form1";
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
    }
}

