namespace ProyectoFinal.Forms.Edicion
{
    partial class FormEdicionDoctor
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
            HorariosDGV = new DataGridView();
            HorarioLabel = new Label();
            HorarioTxt = new TextBox();
            GuardarBtn = new Button();
            VolverBtn = new Button();
            NombreLabel = new Label();
            EspecialidadLabel = new Label();
            TelefonoLabel = new Label();
            NombreTxt = new TextBox();
            TelefonoTxt = new TextBox();
            EspecialidadTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)HorariosDGV).BeginInit();
            SuspendLayout();
            // 
            // HorariosDGV
            // 
            HorariosDGV.AllowUserToAddRows = false;
            HorariosDGV.AllowUserToDeleteRows = false;
            HorariosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HorariosDGV.Location = new Point(279, 34);
            HorariosDGV.Name = "HorariosDGV";
            HorariosDGV.ReadOnly = true;
            HorariosDGV.Size = new Size(514, 356);
            HorariosDGV.TabIndex = 0;
            HorariosDGV.CellClick += HorariosDGV_CellClick;
            // 
            // HorarioLabel
            // 
            HorarioLabel.AutoSize = true;
            HorarioLabel.Location = new Point(41, 96);
            HorarioLabel.Name = "HorarioLabel";
            HorarioLabel.Size = new Size(47, 15);
            HorarioLabel.TabIndex = 1;
            HorarioLabel.Text = "Horario";
            // 
            // HorarioTxt
            // 
            HorarioTxt.Location = new Point(42, 124);
            HorarioTxt.Name = "HorarioTxt";
            HorarioTxt.Size = new Size(100, 23);
            HorarioTxt.TabIndex = 2;
            // 
            // GuardarBtn
            // 
            GuardarBtn.Location = new Point(42, 318);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(75, 23);
            GuardarBtn.TabIndex = 3;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.UseVisualStyleBackColor = true;
            GuardarBtn.Click += GuardarBtn_Click_1;
            // 
            // VolverBtn
            // 
            VolverBtn.Location = new Point(41, 378);
            VolverBtn.Name = "VolverBtn";
            VolverBtn.Size = new Size(75, 23);
            VolverBtn.TabIndex = 4;
            VolverBtn.Text = "Volver";
            VolverBtn.UseVisualStyleBackColor = true;
            VolverBtn.Click += VolverBtn_Click;
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(43, 32);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(107, 15);
            NombreLabel.TabIndex = 5;
            NombreLabel.Text = "Nombre Completo";
            // 
            // EspecialidadLabel
            // 
            EspecialidadLabel.AutoSize = true;
            EspecialidadLabel.Location = new Point(43, 210);
            EspecialidadLabel.Name = "EspecialidadLabel";
            EspecialidadLabel.Size = new Size(72, 15);
            EspecialidadLabel.TabIndex = 6;
            EspecialidadLabel.Text = "Especialidad";
            // 
            // TelefonoLabel
            // 
            TelefonoLabel.AutoSize = true;
            TelefonoLabel.Location = new Point(43, 166);
            TelefonoLabel.Name = "TelefonoLabel";
            TelefonoLabel.Size = new Size(52, 15);
            TelefonoLabel.TabIndex = 7;
            TelefonoLabel.Text = "Telefono";
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(41, 57);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(100, 23);
            NombreTxt.TabIndex = 8;
            // 
            // TelefonoTxt
            // 
            TelefonoTxt.Location = new Point(50, 189);
            TelefonoTxt.Name = "TelefonoTxt";
            TelefonoTxt.Size = new Size(100, 23);
            TelefonoTxt.TabIndex = 9;
            // 
            // EspecialidadTxt
            // 
            EspecialidadTxt.Location = new Point(43, 230);
            EspecialidadTxt.Name = "EspecialidadTxt";
            EspecialidadTxt.Size = new Size(100, 23);
            EspecialidadTxt.TabIndex = 10;
            // 
            // EdicionDoctores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 450);
            Controls.Add(EspecialidadTxt);
            Controls.Add(TelefonoTxt);
            Controls.Add(NombreTxt);
            Controls.Add(TelefonoLabel);
            Controls.Add(EspecialidadLabel);
            Controls.Add(NombreLabel);
            Controls.Add(VolverBtn);
            Controls.Add(GuardarBtn);
            Controls.Add(HorarioTxt);
            Controls.Add(HorarioLabel);
            Controls.Add(HorariosDGV);
            Name = "EdicionDoctores";
            Text = "EdicionHorarios";
            ((System.ComponentModel.ISupportInitialize)HorariosDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HorariosDGV;
        private Label HorarioLabel;
        private TextBox HorarioTxt;
        private Button GuardarBtn;
        private Button VolverBtn;
        private Label NombreLabel;
        private Label EspecialidadLabel;
        private Label TelefonoLabel;
        private TextBox NombreTxt;
        private TextBox TelefonoTxt;
        private TextBox EspecialidadTxt;
    }
}