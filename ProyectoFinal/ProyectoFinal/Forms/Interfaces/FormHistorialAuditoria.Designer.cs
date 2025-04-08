namespace ProyectoFinal.Forms.Interfaces
{
    partial class FormHistorialAuditoria
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
            HistorialDGV = new DataGridView();
            VolverBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)HistorialDGV).BeginInit();
            SuspendLayout();
            // 
            // HistorialDGV
            // 
            HistorialDGV.AllowUserToAddRows = false;
            HistorialDGV.AllowUserToDeleteRows = false;
            HistorialDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistorialDGV.Location = new Point(188, 38);
            HistorialDGV.Name = "HistorialDGV";
            HistorialDGV.ReadOnly = true;
            HistorialDGV.Size = new Size(504, 384);
            HistorialDGV.TabIndex = 0;
            // 
            // VolverBtn
            // 
            VolverBtn.Location = new Point(44, 347);
            VolverBtn.Name = "VolverBtn";
            VolverBtn.Size = new Size(75, 23);
            VolverBtn.TabIndex = 1;
            VolverBtn.Text = "Volver";
            VolverBtn.UseVisualStyleBackColor = true;
            VolverBtn.Click += VolverBtn_Click;
            // 
            // FormHistorialAuditoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(VolverBtn);
            Controls.Add(HistorialDGV);
            Name = "FormHistorialAuditoria";
            Text = "FormHistorialAuditoria";
            ((System.ComponentModel.ISupportInitialize)HistorialDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HistorialDGV;
        private Button VolverBtn;
    }
}