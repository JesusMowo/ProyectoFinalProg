namespace ProyectoFinal.Forms.Interfaces
{
    partial class FormDoctores
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
            CitasDGV = new DataGridView();
            AtenderCitaBtn = new Button();
            HistorialMedicoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CitasDGV).BeginInit();
            SuspendLayout();
            // 
            // CitasDGV
            // 
            CitasDGV.AllowUserToAddRows = false;
            CitasDGV.AllowUserToDeleteRows = false;
            CitasDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CitasDGV.Location = new Point(272, 52);
            CitasDGV.Name = "CitasDGV";
            CitasDGV.ReadOnly = true;
            CitasDGV.Size = new Size(404, 384);
            CitasDGV.TabIndex = 0;
            // 
            // AtenderCitaBtn
            // 
            AtenderCitaBtn.Location = new Point(51, 184);
            AtenderCitaBtn.Name = "AtenderCitaBtn";
            AtenderCitaBtn.Size = new Size(123, 23);
            AtenderCitaBtn.TabIndex = 1;
            AtenderCitaBtn.Text = "Atender Cita";
            AtenderCitaBtn.UseVisualStyleBackColor = true;
            // 
            // HistorialMedicoBtn
            // 
            HistorialMedicoBtn.Location = new Point(51, 246);
            HistorialMedicoBtn.Name = "HistorialMedicoBtn";
            HistorialMedicoBtn.Size = new Size(123, 23);
            HistorialMedicoBtn.TabIndex = 2;
            HistorialMedicoBtn.Text = "Historial Medico";
            HistorialMedicoBtn.UseVisualStyleBackColor = true;
            // 
            // FormDoctores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 475);
            Controls.Add(HistorialMedicoBtn);
            Controls.Add(AtenderCitaBtn);
            Controls.Add(CitasDGV);
            Name = "FormDoctores";
            Text = "FormDoctores";
            ((System.ComponentModel.ISupportInitialize)CitasDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CitasDGV;
        private Button AtenderCitaBtn;
        private Button HistorialMedicoBtn;
    }
}