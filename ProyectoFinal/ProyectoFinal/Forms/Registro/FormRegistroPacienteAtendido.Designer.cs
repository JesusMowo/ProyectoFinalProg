namespace ProyectoFinal.Forms.Registro
{
    partial class FormRegistroPacienteAtendido
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
            ProductosDgv = new DataGridView();
            UsarProductoBtn = new Button();
            CantidadTxt = new TextBox();
            DiagnosticoTxt = new TextBox();
            TratamientoTxt = new TextBox();
            ObservacionesTxt = new TextBox();
            EvolucionTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            RegistrarHistorialBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductosDgv).BeginInit();
            SuspendLayout();
            // 
            // ProductosDgv
            // 
            ProductosDgv.AllowUserToAddRows = false;
            ProductosDgv.AllowUserToDeleteRows = false;
            ProductosDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDgv.Location = new Point(460, 46);
            ProductosDgv.Name = "ProductosDgv";
            ProductosDgv.ReadOnly = true;
            ProductosDgv.Size = new Size(328, 379);
            ProductosDgv.TabIndex = 0;
            // 
            // UsarProductoBtn
            // 
            UsarProductoBtn.Location = new Point(290, 46);
            UsarProductoBtn.Name = "UsarProductoBtn";
            UsarProductoBtn.Size = new Size(154, 23);
            UsarProductoBtn.TabIndex = 1;
            UsarProductoBtn.Text = "Usar Producto";
            UsarProductoBtn.UseVisualStyleBackColor = true;
            UsarProductoBtn.Click += UsarProductoBtn_Click;
            // 
            // CantidadTxt
            // 
            CantidadTxt.Location = new Point(289, 95);
            CantidadTxt.Name = "CantidadTxt";
            CantidadTxt.Size = new Size(100, 23);
            CantidadTxt.TabIndex = 2;
            // 
            // DiagnosticoTxt
            // 
            DiagnosticoTxt.Location = new Point(55, 78);
            DiagnosticoTxt.Name = "DiagnosticoTxt";
            DiagnosticoTxt.Size = new Size(100, 23);
            DiagnosticoTxt.TabIndex = 3;
            // 
            // TratamientoTxt
            // 
            TratamientoTxt.Location = new Point(54, 128);
            TratamientoTxt.Name = "TratamientoTxt";
            TratamientoTxt.Size = new Size(100, 23);
            TratamientoTxt.TabIndex = 4;
            // 
            // ObservacionesTxt
            // 
            ObservacionesTxt.Location = new Point(53, 179);
            ObservacionesTxt.Name = "ObservacionesTxt";
            ObservacionesTxt.Size = new Size(100, 23);
            ObservacionesTxt.TabIndex = 5;
            // 
            // EvolucionTxt
            // 
            EvolucionTxt.Location = new Point(56, 233);
            EvolucionTxt.Name = "EvolucionTxt";
            EvolucionTxt.Size = new Size(100, 23);
            EvolucionTxt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 48);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 7;
            label1.Text = "Diagnostico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 106);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 8;
            label2.Text = "Tratamiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 152);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 9;
            label3.Text = "Observaciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 213);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 10;
            label4.Text = "Evolucion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 75);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 11;
            label5.Text = "Cantidad utilizada";
            // 
            // RegistrarHistorialBtn
            // 
            RegistrarHistorialBtn.Location = new Point(58, 294);
            RegistrarHistorialBtn.Name = "RegistrarHistorialBtn";
            RegistrarHistorialBtn.Size = new Size(75, 23);
            RegistrarHistorialBtn.TabIndex = 12;
            RegistrarHistorialBtn.Text = "Guardar";
            RegistrarHistorialBtn.UseVisualStyleBackColor = true;
            RegistrarHistorialBtn.Click += RegistrarHistorialBtn_Click;
            // 
            // FormRegistroPacienteAtendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegistrarHistorialBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EvolucionTxt);
            Controls.Add(ObservacionesTxt);
            Controls.Add(TratamientoTxt);
            Controls.Add(DiagnosticoTxt);
            Controls.Add(CantidadTxt);
            Controls.Add(UsarProductoBtn);
            Controls.Add(ProductosDgv);
            Name = "FormRegistroPacienteAtendido";
            Text = "FormRegistroPacienteAtendido";
            ((System.ComponentModel.ISupportInitialize)ProductosDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductosDgv;
        private Button UsarProductoBtn;
        private TextBox CantidadTxt;
        private TextBox DiagnosticoTxt;
        private TextBox TratamientoTxt;
        private TextBox ObservacionesTxt;
        private TextBox EvolucionTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button RegistrarHistorialBtn;
    }
}