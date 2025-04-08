namespace ProyectoFinal.Forms.Interfaces
{
    partial class FormVerCitas
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
            VolverBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CitasDGV).BeginInit();
            SuspendLayout();
            // 
            // CitasDGV
            // 
            CitasDGV.AllowUserToAddRows = false;
            CitasDGV.AllowUserToDeleteRows = false;
            CitasDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CitasDGV.Location = new Point(210, 30);
            CitasDGV.Name = "CitasDGV";
            CitasDGV.ReadOnly = true;
            CitasDGV.Size = new Size(479, 391);
            CitasDGV.TabIndex = 0;
            // 
            // VolverBtn
            // 
            VolverBtn.Location = new Point(48, 321);
            VolverBtn.Name = "VolverBtn";
            VolverBtn.Size = new Size(75, 23);
            VolverBtn.TabIndex = 1;
            VolverBtn.Text = "Volver";
            VolverBtn.UseVisualStyleBackColor = true;
            // 
            // FormVerCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(VolverBtn);
            Controls.Add(CitasDGV);
            Name = "FormVerCitas";
            Text = "FormVerCitas";
            ((System.ComponentModel.ISupportInitialize)CitasDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CitasDGV;
        private Button VolverBtn;
    }
}