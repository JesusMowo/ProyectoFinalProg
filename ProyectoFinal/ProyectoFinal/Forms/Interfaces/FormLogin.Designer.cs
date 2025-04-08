namespace ProyectoFinal
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserTxtBox = new TextBox();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            NewAccBtn = new Button();
            Userlabel = new Label();
            PasswordLabel = new Label();
            SuspendLayout();
            // 
            // UserTxtBox
            // 
            UserTxtBox.Location = new Point(151, 112);
            UserTxtBox.Name = "UserTxtBox";
            UserTxtBox.Size = new Size(100, 23);
            UserTxtBox.TabIndex = 0;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(151, 180);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(100, 23);
            PasswordTxtBox.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(162, 234);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 23);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // NewAccBtn
            // 
            NewAccBtn.Location = new Point(269, 366);
            NewAccBtn.Name = "NewAccBtn";
            NewAccBtn.Size = new Size(98, 23);
            NewAccBtn.TabIndex = 3;
            NewAccBtn.Text = "Crear Cuenta";
            NewAccBtn.UseVisualStyleBackColor = true;
            NewAccBtn.Click += NewAccBtn_Click;
            // 
            // Userlabel
            // 
            Userlabel.AutoSize = true;
            Userlabel.Location = new Point(151, 94);
            Userlabel.Name = "Userlabel";
            Userlabel.Size = new Size(47, 15);
            Userlabel.TabIndex = 4;
            Userlabel.Text = "Usuario";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(151, 162);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(67, 15);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Contraseña";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 418);
            Controls.Add(PasswordLabel);
            Controls.Add(Userlabel);
            Controls.Add(NewAccBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UserTxtBox);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserTxtBox;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private Button NewAccBtn;
        private Label Userlabel;
        private Label PasswordLabel;
    }
}
