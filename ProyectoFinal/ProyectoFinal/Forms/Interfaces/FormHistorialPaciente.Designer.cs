namespace ProyectoFinal.Forms.Interfaces
{
    partial class FormHistorialPaciente
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
            dgvHistorialPaciente = new DataGridView();
            VolverBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialPaciente).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorialPaciente
            // 
            dgvHistorialPaciente.AllowUserToAddRows = false;
            dgvHistorialPaciente.AllowUserToDeleteRows = false;
            dgvHistorialPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialPaciente.Location = new Point(208, 12);
            dgvHistorialPaciente.Name = "dgvHistorialPaciente";
            dgvHistorialPaciente.ReadOnly = true;
            dgvHistorialPaciente.Size = new Size(406, 418);
            dgvHistorialPaciente.TabIndex = 0;
            // 
            // VolverBtn
            // 
            VolverBtn.Location = new Point(30, 349);
            VolverBtn.Name = "VolverBtn";
            VolverBtn.Size = new Size(75, 23);
            VolverBtn.TabIndex = 1;
            VolverBtn.Text = "Volver";
            VolverBtn.UseVisualStyleBackColor = true;
            VolverBtn.Click += VolverBtn_Click;
            // 
            // FormHistorialPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 450);
            Controls.Add(VolverBtn);
            Controls.Add(dgvHistorialPaciente);
            Name = "FormHistorialPaciente";
            Text = "FormHistorialPaciente";
            ((System.ComponentModel.ISupportInitialize)dgvHistorialPaciente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorialPaciente;
        private Button VolverBtn;
    }
}