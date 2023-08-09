namespace Risxpert
{
    partial class Risxpert0
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Fases = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha1 = new System.Windows.Forms.Button();
            this.Analista1 = new System.Windows.Forms.Button();
            this.BtnEliminar1 = new System.Windows.Forms.Button();
            this.BtnGuardar1 = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Fecha2 = new System.Windows.Forms.Button();
            this.BtnGuardar2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnGuardar3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.Fecha3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.Fecha4 = new System.Windows.Forms.Button();
            this.dataGridFase4 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Risxpert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fases.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFase4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Fases
            // 
            this.Fases.AccessibleDescription = "Fase1";
            this.Fases.AccessibleName = "Fase1";
            this.Fases.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.Fases.Controls.Add(this.tabPage1);
            this.Fases.Controls.Add(this.tabPage2);
            this.Fases.Controls.Add(this.tabPage3);
            this.Fases.Controls.Add(this.tabPage4);
            this.Fases.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Fases.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Fases.ItemSize = new System.Drawing.Size(250, 40);
            this.Fases.Location = new System.Drawing.Point(0, 36);
            this.Fases.Name = "Fases";
            this.Fases.SelectedIndex = 0;
            this.Fases.Size = new System.Drawing.Size(1005, 342);
            this.Fases.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Fases.TabIndex = 4;
            this.Fases.Tag = "Fase 6";
            this.Fases.SelectedIndexChanged += new System.EventHandler(this.Fases_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Red;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Fecha1);
            this.tabPage1.Controls.Add(this.Analista1);
            this.tabPage1.Controls.Add(this.BtnEliminar1);
            this.tabPage1.Controls.Add(this.BtnGuardar1);
            this.tabPage1.Controls.Add(this.BtnAgregar);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fase 1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(842, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(842, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Activo,
            this.Riesgo,
            this.Dano});
            this.dataGridView1.Location = new System.Drawing.Point(189, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 217);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            // 
            // Riesgo
            // 
            this.Riesgo.HeaderText = "Riesgo";
            this.Riesgo.Name = "Riesgo";
            // 
            // Dano
            // 
            this.Dano.HeaderText = "Daño";
            this.Dano.Name = "Dano";
            // 
            // Fecha1
            // 
            this.Fecha1.BackColor = System.Drawing.Color.Gainsboro;
            this.Fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha1.Location = new System.Drawing.Point(736, 65);
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.Size = new System.Drawing.Size(75, 23);
            this.Fecha1.TabIndex = 4;
            this.Fecha1.Text = "Fecha";
            this.Fecha1.UseVisualStyleBackColor = false;
            this.Fecha1.Click += new System.EventHandler(this.Fecha1_Click);
            // 
            // Analista1
            // 
            this.Analista1.BackColor = System.Drawing.Color.Gainsboro;
            this.Analista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Analista1.Location = new System.Drawing.Point(736, 28);
            this.Analista1.Name = "Analista1";
            this.Analista1.Size = new System.Drawing.Size(75, 23);
            this.Analista1.TabIndex = 3;
            this.Analista1.Text = "Analista";
            this.Analista1.UseVisualStyleBackColor = false;
            this.Analista1.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnEliminar1
            // 
            this.BtnEliminar1.AccessibleName = "BtnEliminar";
            this.BtnEliminar1.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar1.Location = new System.Drawing.Point(61, 152);
            this.BtnEliminar1.Name = "BtnEliminar1";
            this.BtnEliminar1.Size = new System.Drawing.Size(85, 34);
            this.BtnEliminar1.TabIndex = 2;
            this.BtnEliminar1.Text = "Eliminar";
            this.BtnEliminar1.UseVisualStyleBackColor = false;
            this.BtnEliminar1.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnGuardar1
            // 
            this.BtnGuardar1.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar1.Location = new System.Drawing.Point(61, 99);
            this.BtnGuardar1.Name = "BtnGuardar1";
            this.BtnGuardar1.Size = new System.Drawing.Size(85, 32);
            this.BtnGuardar1.TabIndex = 1;
            this.BtnGuardar1.Text = "Guardar";
            this.BtnGuardar1.UseVisualStyleBackColor = false;
            this.BtnGuardar1.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Blue;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(61, 38);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(85, 37);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.Fecha2);
            this.tabPage2.Controls.Add(this.BtnGuardar2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fase 2";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(842, 18);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // Fecha2
            // 
            this.Fecha2.BackColor = System.Drawing.Color.Gainsboro;
            this.Fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha2.Location = new System.Drawing.Point(739, 15);
            this.Fecha2.Name = "Fecha2";
            this.Fecha2.Size = new System.Drawing.Size(75, 23);
            this.Fecha2.TabIndex = 11;
            this.Fecha2.Text = "Fecha";
            this.Fecha2.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar2
            // 
            this.BtnGuardar2.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar2.Location = new System.Drawing.Point(456, 6);
            this.BtnGuardar2.Name = "BtnGuardar2";
            this.BtnGuardar2.Size = new System.Drawing.Size(85, 32);
            this.BtnGuardar2.TabIndex = 9;
            this.BtnGuardar2.Text = "Guardar";
            this.BtnGuardar2.UseVisualStyleBackColor = false;
            this.BtnGuardar2.Click += new System.EventHandler(this.BtnGuardar2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column9,
            this.F,
            this.S,
            this.P,
            this.E,
            this.A,
            this.V});
            this.dataGridView2.Location = new System.Drawing.Point(61, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(546, 234);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_CellBeginEdit);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFase6_CellContentClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Activo";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Riesgo";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Daño";
            this.Column9.Name = "Column9";
            this.Column9.Width = 50;
            // 
            // F
            // 
            this.F.HeaderText = "F";
            this.F.Name = "F";
            this.F.Width = 50;
            // 
            // S
            // 
            this.S.HeaderText = "S";
            this.S.Name = "S";
            this.S.Width = 50;
            // 
            // P
            // 
            this.P.HeaderText = "P";
            this.P.Name = "P";
            this.P.Width = 50;
            // 
            // E
            // 
            this.E.HeaderText = "E";
            this.E.Name = "E";
            this.E.Width = 50;
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            this.A.Width = 50;
            // 
            // V
            // 
            this.V.HeaderText = "V";
            this.V.Name = "V";
            this.V.Width = 50;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.BtnGuardar3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.dateTimePicker3);
            this.tabPage3.Controls.Add(this.Fecha3);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(997, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fase 3";
            // 
            // BtnGuardar3
            // 
            this.BtnGuardar3.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar3.Location = new System.Drawing.Point(386, 6);
            this.BtnGuardar3.Name = "BtnGuardar3";
            this.BtnGuardar3.Size = new System.Drawing.Size(85, 32);
            this.BtnGuardar3.TabIndex = 22;
            this.BtnGuardar3.Text = "Guardar";
            this.BtnGuardar3.UseVisualStyleBackColor = false;
            this.BtnGuardar3.Click += new System.EventHandler(this.BtnGuardar3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column10,
            this.Column11,
            this.Column12,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView3.Location = new System.Drawing.Point(161, 57);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(444, 234);
            this.dataGridView3.TabIndex = 21;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(818, 11);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker3.TabIndex = 19;
            // 
            // Fecha3
            // 
            this.Fecha3.BackColor = System.Drawing.Color.SeaShell;
            this.Fecha3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha3.Location = new System.Drawing.Point(712, 11);
            this.Fecha3.Name = "Fecha3";
            this.Fecha3.Size = new System.Drawing.Size(75, 23);
            this.Fecha3.TabIndex = 18;
            this.Fecha3.Text = "Fecha";
            this.Fecha3.UseVisualStyleBackColor = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage4.Controls.Add(this.dateTimePicker4);
            this.tabPage4.Controls.Add(this.Fecha4);
            this.tabPage4.Controls.Add(this.dataGridFase4);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(997, 294);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fase 4";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(799, 26);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker4.TabIndex = 23;
            // 
            // Fecha4
            // 
            this.Fecha4.BackColor = System.Drawing.Color.SeaShell;
            this.Fecha4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha4.Location = new System.Drawing.Point(706, 23);
            this.Fecha4.Name = "Fecha4";
            this.Fecha4.Size = new System.Drawing.Size(75, 23);
            this.Fecha4.TabIndex = 22;
            this.Fecha4.Text = "Fecha";
            this.Fecha4.UseVisualStyleBackColor = false;
            // 
            // dataGridFase4
            // 
            this.dataGridFase4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridFase4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFase4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column13});
            this.dataGridFase4.Location = new System.Drawing.Point(166, 65);
            this.dataGridFase4.Name = "dataGridFase4";
            this.dataGridFase4.Size = new System.Drawing.Size(455, 216);
            this.dataGridFase4.TabIndex = 0;
            this.dataGridFase4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFase6_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Activo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Riesgo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CR";
            this.Column3.Name = "Column3";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Clasificacion de Riesgo";
            this.Column13.Name = "Column13";
            // 
            // Risxpert
            // 
            this.Risxpert.BackColor = System.Drawing.Color.Gray;
            this.Risxpert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Risxpert.Location = new System.Drawing.Point(409, 0);
            this.Risxpert.Name = "Risxpert";
            this.Risxpert.Size = new System.Drawing.Size(216, 32);
            this.Risxpert.TabIndex = 1;
            this.Risxpert.Text = "Risxpert";
            this.Risxpert.UseVisualStyleBackColor = false;
            this.Risxpert.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Risxpert);
            this.panel1.Controls.Add(this.Fases);
            this.panel1.Location = new System.Drawing.Point(-53, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 383);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Daño";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Riesgo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "CR";
            this.Column12.Name = "Column12";
            this.Column12.Width = 50;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "PB";
            this.Column11.Name = "Column11";
            this.Column11.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Caracter de Riesgo";
            this.Column10.Name = "Column10";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // Risxpert0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(948, 372);
            this.Controls.Add(this.panel1);
            this.Name = "Risxpert0";
            this.Text = "Risxpert Proyecto";
            this.Load += new System.EventHandler(this.Risxpert0_Load);
            this.Fases.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFase4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl Fases;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Fecha1;
        private System.Windows.Forms.Button Analista1;
        private System.Windows.Forms.Button BtnGuardar1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Risxpert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Fecha2;
        private System.Windows.Forms.Button BtnGuardar2;
        private System.Windows.Forms.Button Fecha3;
        private System.Windows.Forms.Button Fecha4;
        private System.Windows.Forms.DataGridView dataGridFase4;
        public System.Windows.Forms.Button BtnEliminar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Button BtnGuardar3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Riesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

