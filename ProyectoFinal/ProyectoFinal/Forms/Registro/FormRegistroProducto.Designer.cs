namespace ProyectoFinal.Forms.Registro
{
    partial class FormRegistroProducto
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
            ProductoTxt = new TextBox();
            CantidadTxt = new TextBox();
            GuardarBtn = new Button();
            SuspendLayout();
            // 
            // ProductoTxt
            // 
            ProductoTxt.Location = new Point(102, 70);
            ProductoTxt.Name = "ProductoTxt";
            ProductoTxt.Size = new Size(100, 23);
            ProductoTxt.TabIndex = 0;
            // 
            // CantidadTxt
            // 
            CantidadTxt.Location = new Point(103, 127);
            CantidadTxt.Name = "CantidadTxt";
            CantidadTxt.Size = new Size(100, 23);
            CantidadTxt.TabIndex = 1;
            // 
            // GuardarBtn
            // 
            GuardarBtn.Location = new Point(106, 187);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(75, 23);
            GuardarBtn.TabIndex = 2;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.UseVisualStyleBackColor = true;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // FormRegistroProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(GuardarBtn);
            Controls.Add(CantidadTxt);
            Controls.Add(ProductoTxt);
            Name = "FormRegistroProducto";
            Text = "FormRegistroProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProductoTxt;
        private TextBox CantidadTxt;
        private Button GuardarBtn;
    }
}