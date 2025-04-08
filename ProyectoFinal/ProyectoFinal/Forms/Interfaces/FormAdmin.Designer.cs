namespace ProyectoFinal
{
    partial class FormAdmin
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
            UsernameLabel = new Label();
            NewDocBtn = new Button();
            AlmacenBtn = new Button();
            HorariosBtn = new Button();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(41, 19);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(0, 15);
            UsernameLabel.TabIndex = 0;
            // 
            // NewDocBtn
            // 
            NewDocBtn.Location = new Point(83, 322);
            NewDocBtn.Name = "NewDocBtn";
            NewDocBtn.Size = new Size(96, 23);
            NewDocBtn.TabIndex = 1;
            NewDocBtn.Text = "Crear Doctor";
            NewDocBtn.UseVisualStyleBackColor = true;
            NewDocBtn.Click += NewDocBtn_Click;
            // 
            // AlmacenBtn
            // 
            AlmacenBtn.Location = new Point(83, 248);
            AlmacenBtn.Name = "AlmacenBtn";
            AlmacenBtn.Size = new Size(75, 23);
            AlmacenBtn.TabIndex = 2;
            AlmacenBtn.Text = "Almacen";
            AlmacenBtn.UseVisualStyleBackColor = true;
            AlmacenBtn.Click += AlmacenBtn_Click;
            // 
            // HorariosBtn
            // 
            HorariosBtn.Location = new Point(82, 190);
            HorariosBtn.Name = "HorariosBtn";
            HorariosBtn.Size = new Size(97, 23);
            HorariosBtn.TabIndex = 3;
            HorariosBtn.Text = "Edittar Horarios";
            HorariosBtn.UseVisualStyleBackColor = true;
            HorariosBtn.Click += HorariosBtn_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 450);
            Controls.Add(HorariosBtn);
            Controls.Add(AlmacenBtn);
            Controls.Add(NewDocBtn);
            Controls.Add(UsernameLabel);
            Name = "FormAdmin";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
        private Button NewDocBtn;
        private Button AlmacenBtn;
        private Button HorariosBtn;
    }
}