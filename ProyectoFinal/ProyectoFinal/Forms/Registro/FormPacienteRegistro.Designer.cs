namespace ProyectoFinal.Forms.Registro
{
    partial class FormPacienteRegistro
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
            FullnameTxtBox = new TextBox();
            EdadTxtBox = new TextBox();
            FullNameLabel = new Label();
            EdadLabel = new Label();
            HistorialLabel = new Label();
            HistorialRTbox = new RichTextBox();
            ObservacionesRTBox = new RichTextBox();
            ObservacionesRTXbox = new Label();
            RegistrarBtn = new Button();
            SuspendLayout();
            // 
            // FullnameTxtBox
            // 
            FullnameTxtBox.Location = new Point(102, 54);
            FullnameTxtBox.Name = "FullnameTxtBox";
            FullnameTxtBox.Size = new Size(100, 23);
            FullnameTxtBox.TabIndex = 0;
            // 
            // EdadTxtBox
            // 
            EdadTxtBox.Location = new Point(102, 98);
            EdadTxtBox.Name = "EdadTxtBox";
            EdadTxtBox.Size = new Size(100, 23);
            EdadTxtBox.TabIndex = 1;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(102, 30);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(107, 15);
            FullNameLabel.TabIndex = 3;
            FullNameLabel.Text = "Nombre Completo";
            // 
            // EdadLabel
            // 
            EdadLabel.AutoSize = true;
            EdadLabel.Location = new Point(104, 80);
            EdadLabel.Name = "EdadLabel";
            EdadLabel.Size = new Size(33, 15);
            EdadLabel.TabIndex = 4;
            EdadLabel.Text = "Edad";
            // 
            // HistorialLabel
            // 
            HistorialLabel.AutoSize = true;
            HistorialLabel.Location = new Point(104, 126);
            HistorialLabel.Name = "HistorialLabel";
            HistorialLabel.Size = new Size(91, 15);
            HistorialLabel.TabIndex = 5;
            HistorialLabel.Text = "Historial Clinico";
            // 
            // HistorialRTbox
            // 
            HistorialRTbox.Location = new Point(102, 144);
            HistorialRTbox.Name = "HistorialRTbox";
            HistorialRTbox.Size = new Size(273, 96);
            HistorialRTbox.TabIndex = 6;
            HistorialRTbox.Text = "";
            // 
            // ObservacionesRTBox
            // 
            ObservacionesRTBox.Location = new Point(102, 263);
            ObservacionesRTBox.Name = "ObservacionesRTBox";
            ObservacionesRTBox.Size = new Size(273, 96);
            ObservacionesRTBox.TabIndex = 7;
            ObservacionesRTBox.Text = "";
            // 
            // ObservacionesRTXbox
            // 
            ObservacionesRTXbox.AutoSize = true;
            ObservacionesRTXbox.Location = new Point(105, 245);
            ObservacionesRTXbox.Name = "ObservacionesRTXbox";
            ObservacionesRTXbox.Size = new Size(84, 15);
            ObservacionesRTXbox.TabIndex = 10;
            ObservacionesRTXbox.Text = "Observaciones";
            // 
            // RegistrarBtn
            // 
            RegistrarBtn.Location = new Point(257, 379);
            RegistrarBtn.Name = "RegistrarBtn";
            RegistrarBtn.Size = new Size(75, 23);
            RegistrarBtn.TabIndex = 11;
            RegistrarBtn.Text = "Registrarse";
            RegistrarBtn.UseVisualStyleBackColor = true;
            RegistrarBtn.Click += RegistrarBtn_Click;
            // 
            // FormPacienteRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 435);
            Controls.Add(RegistrarBtn);
            Controls.Add(ObservacionesRTXbox);
            Controls.Add(ObservacionesRTBox);
            Controls.Add(HistorialRTbox);
            Controls.Add(HistorialLabel);
            Controls.Add(EdadLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(EdadTxtBox);
            Controls.Add(FullnameTxtBox);
            Name = "FormPacienteRegistro";
            Text = "PacienteRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FullnameTxtBox;
        private TextBox EdadTxtBox;
        private Label FullNameLabel;
        private Label EdadLabel;
        private Label HistorialLabel;
        private RichTextBox HistorialRTbox;
        private RichTextBox ObservacionesRTBox;
        private Label ObservacionesRTXbox;
        private Button RegistrarBtn;
    }
}