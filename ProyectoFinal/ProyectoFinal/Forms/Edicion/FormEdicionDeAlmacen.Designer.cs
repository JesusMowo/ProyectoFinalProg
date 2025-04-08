namespace ProyectoFinal.Forms.Interfaces
{
    partial class FormAuditoria
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
            EdicionDGV = new DataGridView();
            NombreTxt = new TextBox();
            CantidadTxt = new TextBox();
            NombreLabel = new Label();
            CantidadLabel = new Label();
            GuardarBtn = new Button();
            VolverBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)EdicionDGV).BeginInit();
            SuspendLayout();
            // 
            // EdicionDGV
            // 
            EdicionDGV.AllowUserToAddRows = false;
            EdicionDGV.AllowUserToDeleteRows = false;
            EdicionDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EdicionDGV.Location = new Point(176, 38);
            EdicionDGV.Name = "EdicionDGV";
            EdicionDGV.ReadOnly = true;
            EdicionDGV.Size = new Size(308, 362);
            EdicionDGV.TabIndex = 0;
            EdicionDGV.CellClick += EdicionDGV_CellClick;
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(30, 101);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(100, 23);
            NombreTxt.TabIndex = 2;
            // 
            // CantidadTxt
            // 
            CantidadTxt.Location = new Point(32, 154);
            CantidadTxt.Name = "CantidadTxt";
            CantidadTxt.Size = new Size(100, 23);
            CantidadTxt.TabIndex = 3;
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(30, 76);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(51, 15);
            NombreLabel.TabIndex = 5;
            NombreLabel.Text = "Nombre";
            // 
            // CantidadLabel
            // 
            CantidadLabel.AutoSize = true;
            CantidadLabel.Location = new Point(33, 127);
            CantidadLabel.Name = "CantidadLabel";
            CantidadLabel.Size = new Size(55, 15);
            CantidadLabel.TabIndex = 6;
            CantidadLabel.Text = "Cantidad";
            // 
            // GuardarBtn
            // 
            GuardarBtn.Location = new Point(30, 208);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(75, 23);
            GuardarBtn.TabIndex = 7;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.UseVisualStyleBackColor = true;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // VolverBtn
            // 
            VolverBtn.Location = new Point(34, 378);
            VolverBtn.Name = "VolverBtn";
            VolverBtn.Size = new Size(75, 23);
            VolverBtn.TabIndex = 8;
            VolverBtn.Text = "Volver";
            VolverBtn.UseVisualStyleBackColor = true;
            VolverBtn.Click += VolverBtn_Click;
            // 
            // FormEdicionDeAlmacen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(VolverBtn);
            Controls.Add(GuardarBtn);
            Controls.Add(CantidadLabel);
            Controls.Add(NombreLabel);
            Controls.Add(CantidadTxt);
            Controls.Add(NombreTxt);
            Controls.Add(EdicionDGV);
            Name = "FormEdicionDeAlmacen";
            Text = "FormEdicionDeAlmacen";
            ((System.ComponentModel.ISupportInitialize)EdicionDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView EdicionDGV;
        private TextBox NombreTxt;
        private TextBox CantidadTxt;
        private Label NombreLabel;
        private Label CantidadLabel;
        private Button GuardarBtn;
        private Button VolverBtn;
    }
}