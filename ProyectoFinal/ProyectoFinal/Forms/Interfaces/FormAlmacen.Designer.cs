namespace ProyectoFinal.Forms.Interfaces
{
    partial class FormAlmacen
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
            AlmacenDVG = new DataGridView();
            button1 = new Button();
            AggProductoBtn = new Button();
            EditarAlmacenBtn = new Button();
            HistorialBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AlmacenDVG).BeginInit();
            SuspendLayout();
            // 
            // AlmacenDVG
            // 
            AlmacenDVG.AllowUserToAddRows = false;
            AlmacenDVG.AllowUserToDeleteRows = false;
            AlmacenDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AlmacenDVG.Location = new Point(240, 25);
            AlmacenDVG.Name = "AlmacenDVG";
            AlmacenDVG.Size = new Size(407, 399);
            AlmacenDVG.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(60, 374);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AggProductoBtn
            // 
            AggProductoBtn.Location = new Point(39, 72);
            AggProductoBtn.Name = "AggProductoBtn";
            AggProductoBtn.Size = new Size(156, 23);
            AggProductoBtn.TabIndex = 2;
            AggProductoBtn.Text = "Agregar Producto";
            AggProductoBtn.UseVisualStyleBackColor = true;
            AggProductoBtn.Click += AggProductoBtn_Click;
            // 
            // EditarAlmacenBtn
            // 
            EditarAlmacenBtn.Location = new Point(39, 129);
            EditarAlmacenBtn.Name = "EditarAlmacenBtn";
            EditarAlmacenBtn.Size = new Size(156, 23);
            EditarAlmacenBtn.TabIndex = 3;
            EditarAlmacenBtn.Text = "Editar Almacen";
            EditarAlmacenBtn.UseVisualStyleBackColor = true;
            EditarAlmacenBtn.Click += EditarAlmacenBtn_Click;
            // 
            // HistorialBtn
            // 
            HistorialBtn.Location = new Point(41, 184);
            HistorialBtn.Name = "HistorialBtn";
            HistorialBtn.Size = new Size(154, 23);
            HistorialBtn.TabIndex = 4;
            HistorialBtn.Text = "Historial de Movimientos";
            HistorialBtn.UseVisualStyleBackColor = true;
            HistorialBtn.Click += HistorialBtn_Click;
            // 
            // FormAlmacen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 450);
            Controls.Add(HistorialBtn);
            Controls.Add(EditarAlmacenBtn);
            Controls.Add(AggProductoBtn);
            Controls.Add(button1);
            Controls.Add(AlmacenDVG);
            Name = "FormAlmacen";
            Text = "Almacen";
            ((System.ComponentModel.ISupportInitialize)AlmacenDVG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AlmacenDVG;
        private Button button1;
        private Button AggProductoBtn;
        private Button EditarAlmacenBtn;
        private Button HistorialBtn;
    }
}