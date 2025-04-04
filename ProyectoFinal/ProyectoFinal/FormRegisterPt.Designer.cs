namespace ProyectoFinal
{
    partial class FormRegisterPt
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
            UserTxtBox = new TextBox();
            Password1TxtBox = new TextBox();
            Password2TxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ContinuarRegistro = new Button();
            SuspendLayout();
            // 
            // UserTxtBox
            // 
            UserTxtBox.Location = new Point(130, 128);
            UserTxtBox.Name = "UserTxtBox";
            UserTxtBox.Size = new Size(100, 23);
            UserTxtBox.TabIndex = 0;
            // 
            // Password1TxtBox
            // 
            Password1TxtBox.Location = new Point(130, 193);
            Password1TxtBox.Name = "Password1TxtBox";
            Password1TxtBox.Size = new Size(100, 23);
            Password1TxtBox.TabIndex = 1;
            // 
            // Password2TxtBox
            // 
            Password2TxtBox.Location = new Point(130, 258);
            Password2TxtBox.Name = "Password2TxtBox";
            Password2TxtBox.Size = new Size(100, 23);
            Password2TxtBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 90);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 154);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 231);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "Repetir contraseña";
            // 
            // ContinuarRegistro
            // 
            ContinuarRegistro.Location = new Point(130, 315);
            ContinuarRegistro.Name = "ContinuarRegistro";
            ContinuarRegistro.Size = new Size(129, 23);
            ContinuarRegistro.TabIndex = 6;
            ContinuarRegistro.Text = "Continuar registro";
            ContinuarRegistro.UseVisualStyleBackColor = true;
            ContinuarRegistro.Click += ContinuarRegistro_Click;
            // 
            // FormRegisterPt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ContinuarRegistro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password2TxtBox);
            Controls.Add(Password1TxtBox);
            Controls.Add(UserTxtBox);
            Name = "FormRegisterPt";
            Text = "RegisterPtForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserTxtBox;
        private TextBox Password1TxtBox;
        private TextBox Password2TxtBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ContinuarRegistro;
    }
}