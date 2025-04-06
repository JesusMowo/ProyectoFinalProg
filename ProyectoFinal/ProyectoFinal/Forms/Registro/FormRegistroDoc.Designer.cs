namespace ProyectoFinal.Forms.Registro
{
    partial class FormRegistroDoc
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
            FullnameDocTxt = new TextBox();
            EspecialidadTxt = new TextBox();
            HorarioTxt = new TextBox();
            TelefonoTxt = new TextBox();
            FullnameLabel = new Label();
            EspecialidadLabel = new Label();
            HorariosLabel = new Label();
            TelefonoLabel = new Label();
            RegistroDocBtn = new Button();
            SuspendLayout();
            // 
            // FullnameDocTxt
            // 
            FullnameDocTxt.Location = new Point(80, 67);
            FullnameDocTxt.Name = "FullnameDocTxt";
            FullnameDocTxt.Size = new Size(125, 23);
            FullnameDocTxt.TabIndex = 0;
            // 
            // EspecialidadTxt
            // 
            EspecialidadTxt.Location = new Point(81, 115);
            EspecialidadTxt.Name = "EspecialidadTxt";
            EspecialidadTxt.Size = new Size(124, 23);
            EspecialidadTxt.TabIndex = 1;
            // 
            // HorarioTxt
            // 
            HorarioTxt.Location = new Point(80, 174);
            HorarioTxt.Name = "HorarioTxt";
            HorarioTxt.Size = new Size(125, 23);
            HorarioTxt.TabIndex = 2;
            HorarioTxt.Text = "Formato 00:00-00:00";
            // 
            // TelefonoTxt
            // 
            TelefonoTxt.Location = new Point(80, 216);
            TelefonoTxt.Name = "TelefonoTxt";
            TelefonoTxt.Size = new Size(125, 23);
            TelefonoTxt.TabIndex = 3;
            // 
            // FullnameLabel
            // 
            FullnameLabel.AutoSize = true;
            FullnameLabel.Location = new Point(68, 35);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(107, 15);
            FullnameLabel.TabIndex = 4;
            FullnameLabel.Text = "Nombre Completo";
            // 
            // EspecialidadLabel
            // 
            EspecialidadLabel.AutoSize = true;
            EspecialidadLabel.Location = new Point(77, 93);
            EspecialidadLabel.Name = "EspecialidadLabel";
            EspecialidadLabel.Size = new Size(72, 15);
            EspecialidadLabel.TabIndex = 5;
            EspecialidadLabel.Text = "Especialidad";
            // 
            // HorariosLabel
            // 
            HorariosLabel.AutoSize = true;
            HorariosLabel.Location = new Point(86, 144);
            HorariosLabel.Name = "HorariosLabel";
            HorariosLabel.Size = new Size(52, 15);
            HorariosLabel.TabIndex = 6;
            HorariosLabel.Text = "Horarios";
            // 
            // TelefonoLabel
            // 
            TelefonoLabel.AutoSize = true;
            TelefonoLabel.Location = new Point(80, 198);
            TelefonoLabel.Name = "TelefonoLabel";
            TelefonoLabel.Size = new Size(52, 15);
            TelefonoLabel.TabIndex = 7;
            TelefonoLabel.Text = "Telefono";
            // 
            // RegistroDocBtn
            // 
            RegistroDocBtn.Location = new Point(77, 276);
            RegistroDocBtn.Name = "RegistroDocBtn";
            RegistroDocBtn.Size = new Size(118, 23);
            RegistroDocBtn.TabIndex = 8;
            RegistroDocBtn.Text = "Registrar Doctor";
            RegistroDocBtn.UseVisualStyleBackColor = true;
            RegistroDocBtn.Click += RegistroDocBtn_Click;
            // 
            // FormRegistroDoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(RegistroDocBtn);
            Controls.Add(TelefonoLabel);
            Controls.Add(HorariosLabel);
            Controls.Add(EspecialidadLabel);
            Controls.Add(FullnameLabel);
            Controls.Add(TelefonoTxt);
            Controls.Add(HorarioTxt);
            Controls.Add(EspecialidadTxt);
            Controls.Add(FullnameDocTxt);
            Name = "FormRegistroDoc";
            Text = "FormRegistroDoc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FullnameDocTxt;
        private TextBox EspecialidadTxt;
        private TextBox HorarioTxt;
        private TextBox TelefonoTxt;
        private Label FullnameLabel;
        private Label EspecialidadLabel;
        private Label HorariosLabel;
        private Label TelefonoLabel;
        private Button RegistroDocBtn;
    }
}