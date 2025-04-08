namespace ProyectoFinal.Forms.Interfaces
{
    partial class FormHistorialMedico
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
            dgvHistorialMedico = new DataGridView();
            VolverBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialMedico).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorialMedico
            // 
            dgvHistorialMedico.AllowUserToAddRows = false;
            dgvHistorialMedico.AllowUserToDeleteRows = false;
            dgvHistorialMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialMedico.Location = new Point(139, 12);
            dgvHistorialMedico.Name = "dgvHistorialMedico";
            dgvHistorialMedico.ReadOnly = true;
            dgvHistorialMedico.Size = new Size(441, 426);
            dgvHistorialMedico.TabIndex = 0;
            // 
            // VolverBtn
            // 
            VolverBtn.Location = new Point(28, 383);
            VolverBtn.Name = "VolverBtn";
            VolverBtn.Size = new Size(75, 23);
            VolverBtn.TabIndex = 1;
            VolverBtn.Text = "Volver";
            VolverBtn.UseVisualStyleBackColor = true;
            VolverBtn.Click += VolverBtn_Click_1;
            // 
            // FormHistorialMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 450);
            Controls.Add(VolverBtn);
            Controls.Add(dgvHistorialMedico);
            Name = "FormHistorialMedico";
            Text = "FormHistorialMedico";
            ((System.ComponentModel.ISupportInitialize)dgvHistorialMedico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorialMedico;
        private Button VolverBtn;
    }
}