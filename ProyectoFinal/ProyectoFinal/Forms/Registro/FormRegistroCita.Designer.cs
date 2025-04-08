namespace ProyectoFinal.Forms.Registro
{
    partial class FormRegistroCita
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
            dataGridView1 = new DataGridView();
            DoctorTxt = new TextBox();
            HorarioTxt = new TextBox();
            GuardarCitaBtn = new Button();
            VolverBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            FechasDIsponiblesLbox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(258, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(361, 384);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // DoctorTxt
            // 
            DoctorTxt.Enabled = false;
            DoctorTxt.Location = new Point(21, 71);
            DoctorTxt.Name = "DoctorTxt";
            DoctorTxt.Size = new Size(100, 23);
            DoctorTxt.TabIndex = 1;
            // 
            // HorarioTxt
            // 
            HorarioTxt.Enabled = false;
            HorarioTxt.Location = new Point(20, 126);
            HorarioTxt.Name = "HorarioTxt";
            HorarioTxt.Size = new Size(100, 23);
            HorarioTxt.TabIndex = 2;
            // 
            // GuardarCitaBtn
            // 
            GuardarCitaBtn.Location = new Point(55, 222);
            GuardarCitaBtn.Name = "GuardarCitaBtn";
            GuardarCitaBtn.Size = new Size(94, 23);
            GuardarCitaBtn.TabIndex = 3;
            GuardarCitaBtn.Text = "Agendar Cita";
            GuardarCitaBtn.UseVisualStyleBackColor = true;
            GuardarCitaBtn.Click += GuardarCitaBtn_Click;
            // 
            // VolverBtn
            // 
            VolverBtn.Location = new Point(45, 379);
            VolverBtn.Name = "VolverBtn";
            VolverBtn.Size = new Size(75, 23);
            VolverBtn.TabIndex = 4;
            VolverBtn.Text = "Volver";
            VolverBtn.UseVisualStyleBackColor = true;
            VolverBtn.Click += VolverBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 47);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 102);
            label2.Name = "label2";
            label2.Size = new Size(184, 15);
            label2.TabIndex = 6;
            label2.Text = "Horario (SOLO DIAS DE SEMANA)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(22, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // FechasDIsponiblesLbox
            // 
            FechasDIsponiblesLbox.FormattingEnabled = true;
            FechasDIsponiblesLbox.ItemHeight = 15;
            FechasDIsponiblesLbox.Location = new Point(26, 263);
            FechasDIsponiblesLbox.Name = "FechasDIsponiblesLbox";
            FechasDIsponiblesLbox.Size = new Size(120, 94);
            FechasDIsponiblesLbox.TabIndex = 8;
            FechasDIsponiblesLbox.SelectedIndexChanged += FechasDIsponiblesLbox_SelectedIndexChanged;
            // 
            // FormRegistroCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(FechasDIsponiblesLbox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(VolverBtn);
            Controls.Add(GuardarCitaBtn);
            Controls.Add(HorarioTxt);
            Controls.Add(DoctorTxt);
            Controls.Add(dataGridView1);
            Name = "FormRegistroCita";
            Text = "FormRegistroCita";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox DoctorTxt;
        private TextBox HorarioTxt;
        private Button GuardarCitaBtn;
        private Button VolverBtn;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ListBox FechasDIsponiblesLbox;
    }
}