namespace hospital_Proyecto
{
    partial class Form1
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
            tabControl1 = new TabControl();
            rbChequeo = new TabPage();
            groupBox5 = new GroupBox();
            radioButton16 = new RadioButton();
            radioButton15 = new RadioButton();
            groupBox4 = new GroupBox();
            radioButton12 = new RadioButton();
            radioButton11 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            btnGuardar = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            lblNombre = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            rbChequeo.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(rbChequeo);
            tabControl1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tabControl1.ItemSize = new Size(700, 40);
            tabControl1.Location = new Point(2, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1062, 700);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 0;
            // 
            // rbChequeo
            // 
            rbChequeo.BackColor = SystemColors.ButtonFace;
            rbChequeo.BorderStyle = BorderStyle.Fixed3D;
            rbChequeo.Controls.Add(pictureBox1);
            rbChequeo.Controls.Add(groupBox5);
            rbChequeo.Controls.Add(groupBox4);
            rbChequeo.Controls.Add(groupBox3);
            rbChequeo.Controls.Add(btnGuardar);
            rbChequeo.Controls.Add(dateTimePicker1);
            rbChequeo.Controls.Add(groupBox2);
            rbChequeo.Controls.Add(groupBox1);
            rbChequeo.Controls.Add(textBox1);
            rbChequeo.Controls.Add(lblNombre);
            rbChequeo.Location = new Point(4, 44);
            rbChequeo.Name = "rbChequeo";
            rbChequeo.Padding = new Padding(3);
            rbChequeo.Size = new Size(1054, 652);
            rbChequeo.TabIndex = 0;
            rbChequeo.Text = "Chequeo";
            rbChequeo.UseWaitCursor = true;
            rbChequeo.Click += tabPage1_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(radioButton16);
            groupBox5.Controls.Add(radioButton15);
            groupBox5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(19, 433);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(782, 68);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "¿Tiene algún antecedente médico relevante?";
            // 
            // radioButton16
            // 
            radioButton16.AutoSize = true;
            radioButton16.Location = new Point(278, 41);
            radioButton16.Name = "radioButton16";
            radioButton16.Size = new Size(44, 21);
            radioButton16.TabIndex = 3;
            radioButton16.TabStop = true;
            radioButton16.Text = "No";
            radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            radioButton15.AutoSize = true;
            radioButton15.Location = new Point(10, 41);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(36, 21);
            radioButton15.TabIndex = 2;
            radioButton15.TabStop = true;
            radioButton15.Text = "Si";
            radioButton15.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton12);
            groupBox4.Controls.Add(radioButton11);
            groupBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(18, 343);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(782, 68);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "¿Fuma o consume alcohol?";
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(11, 28);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(40, 21);
            radioButton12.TabIndex = 2;
            radioButton12.TabStop = true;
            radioButton12.Text = " Sí";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(279, 28);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(44, 21);
            radioButton11.TabIndex = 1;
            radioButton11.TabStop = true;
            radioButton11.Text = "No";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton9);
            groupBox3.Controls.Add(radioButton8);
            groupBox3.Controls.Add(radioButton7);
            groupBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(19, 254);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(782, 68);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "¿Con qué frecuencia experimenta los síntomas?";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(555, 34);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(127, 21);
            radioButton9.TabIndex = 2;
            radioButton9.TabStop = true;
            radioButton9.Text = " Ocasionalmente";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(284, 33);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(116, 21);
            radioButton8.TabIndex = 1;
            radioButton8.TabStop = true;
            radioButton8.Text = "Semanalmente";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 34);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(127, 21);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "Constantemente";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGuardar.Location = new Point(398, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 35);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(19, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(781, 73);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = " ¿Puedes describir la intensidad del dolor o malestar?";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(551, 38);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(51, 21);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "Alto";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(278, 38);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(68, 21);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Medio ";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(10, 38);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(56, 21);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = " Bajo";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 71);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "¿Cuál es el motivo de tu visita hoy?";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(551, 31);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(123, 21);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Dolor de cabeza";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(278, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(163, 21);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dificultad para respirar";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Fiebre";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(829, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 1;
            textBox1.UseWaitCursor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(743, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medical_care_color_icon_hospital_hand_holding_medical_cross_isolated_illustration_vector;
            pictureBox1.Location = new Point(947, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 543);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Hospital";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            rbChequeo.ResumeLayout(false);
            rbChequeo.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage rbChequeo;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label lblNombre;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private DateTimePicker dateTimePicker1;
        private Button btnGuardar;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private RadioButton radioButton15;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton16;
        private PictureBox pictureBox1;
    }
}