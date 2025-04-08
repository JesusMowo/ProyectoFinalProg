namespace ProyectoFinal.Forms.Interfaces
{
    partial class FormPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CrearCitaBtn = new Button();
            VerCitasBtn = new Button();
            HistorialClinicoBtn = new Button();
            SuspendLayout();
            // 
            // CrearCitaBtn
            // 
            CrearCitaBtn.Location = new Point(148, 124);
            CrearCitaBtn.Name = "CrearCitaBtn";
            CrearCitaBtn.Size = new Size(102, 23);
            CrearCitaBtn.TabIndex = 0;
            CrearCitaBtn.Text = "Crear Cita";
            CrearCitaBtn.UseVisualStyleBackColor = true;
            CrearCitaBtn.Click += CrearCitaBtn_Click;
            // 
            // VerCitasBtn
            // 
            VerCitasBtn.Location = new Point(148, 168);
            VerCitasBtn.Name = "VerCitasBtn";
            VerCitasBtn.Size = new Size(102, 23);
            VerCitasBtn.TabIndex = 1;
            VerCitasBtn.Text = "Ver Citas";
            VerCitasBtn.UseVisualStyleBackColor = true;
            VerCitasBtn.Click += VerCitasBtn_Click;
            // 
            // HistorialClinicoBtn
            // 
            HistorialClinicoBtn.Location = new Point(151, 214);
            HistorialClinicoBtn.Name = "HistorialClinicoBtn";
            HistorialClinicoBtn.Size = new Size(99, 23);
            HistorialClinicoBtn.TabIndex = 2;
            HistorialClinicoBtn.Text = "Historial Clinico";
            HistorialClinicoBtn.UseVisualStyleBackColor = true;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 450);
            Controls.Add(HistorialClinicoBtn);
            Controls.Add(VerCitasBtn);
            Controls.Add(CrearCitaBtn);
            Name = "FormPaciente";
            Text = "FormPaciente";
            ResumeLayout(false);
        }

        #endregion

        private Button CrearCitaBtn;
        private Button VerCitasBtn;
        private Button HistorialClinicoBtn;
    }
}