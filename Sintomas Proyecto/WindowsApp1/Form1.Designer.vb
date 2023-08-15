<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabChequeo = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.gbNivel = New System.Windows.Forms.GroupBox()
        Me.rbAlto = New System.Windows.Forms.RadioButton()
        Me.rbMedio = New System.Windows.Forms.RadioButton()
        Me.rbBajo = New System.Windows.Forms.RadioButton()
        Me.gbSintomas = New System.Windows.Forms.GroupBox()
        Me.rbDolorenunOrgano = New System.Windows.Forms.RadioButton()
        Me.rbFatiga = New System.Windows.Forms.RadioButton()
        Me.rbDoloresMusculares = New System.Windows.Forms.RadioButton()
        Me.rbFiebre = New System.Windows.Forms.RadioButton()
        Me.rbGanasDeVomitar = New System.Windows.Forms.RadioButton()
        Me.rbMareado = New System.Windows.Forms.RadioButton()
        Me.tabBajo = New System.Windows.Forms.TabPage()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabChequeo.SuspendLayout()
        Me.gbNivel.SuspendLayout()
        Me.gbSintomas.SuspendLayout()
        Me.tabBajo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabChequeo)
        Me.TabControl1.Controls.Add(Me.tabBajo)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1053, 469)
        Me.TabControl1.TabIndex = 0
        '
        'tabChequeo
        '
        Me.tabChequeo.BackColor = System.Drawing.Color.SlateBlue
        Me.tabChequeo.Controls.Add(Me.DateTimePicker1)
        Me.tabChequeo.Controls.Add(Me.txtNombre)
        Me.tabChequeo.Controls.Add(Me.lblNombre)
        Me.tabChequeo.Controls.Add(Me.btnCheck)
        Me.tabChequeo.Controls.Add(Me.gbNivel)
        Me.tabChequeo.Controls.Add(Me.gbSintomas)
        Me.tabChequeo.ForeColor = System.Drawing.Color.Black
        Me.tabChequeo.Location = New System.Drawing.Point(4, 22)
        Me.tabChequeo.Name = "tabChequeo"
        Me.tabChequeo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChequeo.Size = New System.Drawing.Size(1045, 443)
        Me.tabChequeo.TabIndex = 0
        Me.tabChequeo.Text = "Chequeo"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(839, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(939, 42)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Lavender
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(851, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 16)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Text = "Nombre"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Lime
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(417, 25)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 6
        Me.btnCheck.Text = "Guardar"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'gbNivel
        '
        Me.gbNivel.Controls.Add(Me.rbAlto)
        Me.gbNivel.Controls.Add(Me.rbMedio)
        Me.gbNivel.Controls.Add(Me.rbBajo)
        Me.gbNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNivel.Location = New System.Drawing.Point(515, 131)
        Me.gbNivel.Name = "gbNivel"
        Me.gbNivel.Size = New System.Drawing.Size(266, 175)
        Me.gbNivel.TabIndex = 5
        Me.gbNivel.TabStop = False
        Me.gbNivel.Text = "Nivel?"
        '
        'rbAlto
        '
        Me.rbAlto.AutoSize = True
        Me.rbAlto.Location = New System.Drawing.Point(7, 125)
        Me.rbAlto.Name = "rbAlto"
        Me.rbAlto.Size = New System.Drawing.Size(47, 17)
        Me.rbAlto.TabIndex = 2
        Me.rbAlto.TabStop = True
        Me.rbAlto.Text = "Alto"
        Me.rbAlto.UseVisualStyleBackColor = True
        '
        'rbMedio
        '
        Me.rbMedio.AutoSize = True
        Me.rbMedio.Location = New System.Drawing.Point(7, 90)
        Me.rbMedio.Name = "rbMedio"
        Me.rbMedio.Size = New System.Drawing.Size(59, 17)
        Me.rbMedio.TabIndex = 1
        Me.rbMedio.TabStop = True
        Me.rbMedio.Text = "Medio"
        Me.rbMedio.UseVisualStyleBackColor = True
        '
        'rbBajo
        '
        Me.rbBajo.AutoSize = True
        Me.rbBajo.Location = New System.Drawing.Point(7, 51)
        Me.rbBajo.Name = "rbBajo"
        Me.rbBajo.Size = New System.Drawing.Size(50, 17)
        Me.rbBajo.TabIndex = 0
        Me.rbBajo.TabStop = True
        Me.rbBajo.Tag = ""
        Me.rbBajo.Text = "Bajo"
        Me.rbBajo.UseVisualStyleBackColor = True
        '
        'gbSintomas
        '
        Me.gbSintomas.Controls.Add(Me.rbDolorenunOrgano)
        Me.gbSintomas.Controls.Add(Me.rbFatiga)
        Me.gbSintomas.Controls.Add(Me.rbDoloresMusculares)
        Me.gbSintomas.Controls.Add(Me.rbFiebre)
        Me.gbSintomas.Controls.Add(Me.rbGanasDeVomitar)
        Me.gbSintomas.Controls.Add(Me.rbMareado)
        Me.gbSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSintomas.Location = New System.Drawing.Point(196, 116)
        Me.gbSintomas.Name = "gbSintomas"
        Me.gbSintomas.Size = New System.Drawing.Size(229, 256)
        Me.gbSintomas.TabIndex = 4
        Me.gbSintomas.TabStop = False
        Me.gbSintomas.Text = "Que Sintomas Tiene?"
        '
        'rbDolorenunOrgano
        '
        Me.rbDolorenunOrgano.AutoSize = True
        Me.rbDolorenunOrgano.Location = New System.Drawing.Point(7, 209)
        Me.rbDolorenunOrgano.Name = "rbDolorenunOrgano"
        Me.rbDolorenunOrgano.Size = New System.Drawing.Size(136, 17)
        Me.rbDolorenunOrgano.TabIndex = 5
        Me.rbDolorenunOrgano.TabStop = True
        Me.rbDolorenunOrgano.Text = "Dolor en un Organo"
        Me.rbDolorenunOrgano.UseVisualStyleBackColor = True
        '
        'rbFatiga
        '
        Me.rbFatiga.AutoSize = True
        Me.rbFatiga.Location = New System.Drawing.Point(7, 176)
        Me.rbFatiga.Name = "rbFatiga"
        Me.rbFatiga.Size = New System.Drawing.Size(60, 17)
        Me.rbFatiga.TabIndex = 4
        Me.rbFatiga.TabStop = True
        Me.rbFatiga.Text = "Fatiga"
        Me.rbFatiga.UseVisualStyleBackColor = True
        '
        'rbDoloresMusculares
        '
        Me.rbDoloresMusculares.AutoSize = True
        Me.rbDoloresMusculares.Location = New System.Drawing.Point(7, 138)
        Me.rbDoloresMusculares.Name = "rbDoloresMusculares"
        Me.rbDoloresMusculares.Size = New System.Drawing.Size(136, 17)
        Me.rbDoloresMusculares.TabIndex = 3
        Me.rbDoloresMusculares.TabStop = True
        Me.rbDoloresMusculares.Text = "Dolores Musculares"
        Me.rbDoloresMusculares.UseVisualStyleBackColor = True
        '
        'rbFiebre
        '
        Me.rbFiebre.AutoSize = True
        Me.rbFiebre.Location = New System.Drawing.Point(7, 100)
        Me.rbFiebre.Name = "rbFiebre"
        Me.rbFiebre.Size = New System.Drawing.Size(60, 17)
        Me.rbFiebre.TabIndex = 2
        Me.rbFiebre.TabStop = True
        Me.rbFiebre.Text = "Fiebre"
        Me.rbFiebre.UseVisualStyleBackColor = True
        '
        'rbGanasDeVomitar
        '
        Me.rbGanasDeVomitar.AutoSize = True
        Me.rbGanasDeVomitar.Location = New System.Drawing.Point(7, 66)
        Me.rbGanasDeVomitar.Name = "rbGanasDeVomitar"
        Me.rbGanasDeVomitar.Size = New System.Drawing.Size(127, 17)
        Me.rbGanasDeVomitar.TabIndex = 1
        Me.rbGanasDeVomitar.TabStop = True
        Me.rbGanasDeVomitar.Text = "Ganas De Vomitar"
        Me.rbGanasDeVomitar.UseVisualStyleBackColor = True
        '
        'rbMareado
        '
        Me.rbMareado.AutoSize = True
        Me.rbMareado.Location = New System.Drawing.Point(7, 30)
        Me.rbMareado.Name = "rbMareado"
        Me.rbMareado.Size = New System.Drawing.Size(74, 17)
        Me.rbMareado.TabIndex = 0
        Me.rbMareado.TabStop = True
        Me.rbMareado.Text = "Mareado"
        Me.rbMareado.UseVisualStyleBackColor = True
        '
        'tabBajo
        '
        Me.tabBajo.Controls.Add(Me.ProgressBar1)
        Me.tabBajo.Controls.Add(Me.lblResultado)
        Me.tabBajo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tabBajo.Location = New System.Drawing.Point(4, 22)
        Me.tabBajo.Name = "tabBajo"
        Me.tabBajo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBajo.Size = New System.Drawing.Size(1045, 443)
        Me.tabBajo.TabIndex = 1
        Me.tabBajo.Text = "Resultado"
        Me.tabBajo.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Lime
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(7, 147)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1035, 103)
        Me.ProgressBar1.TabIndex = 1
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.BackColor = System.Drawing.Color.Yellow
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(8, 16)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(78, 16)
        Me.lblResultado.TabIndex = 0
        Me.lblResultado.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tabChequeo.ResumeLayout(False)
        Me.tabChequeo.PerformLayout()
        Me.gbNivel.ResumeLayout(False)
        Me.gbNivel.PerformLayout()
        Me.gbSintomas.ResumeLayout(False)
        Me.gbSintomas.PerformLayout()
        Me.tabBajo.ResumeLayout(False)
        Me.tabBajo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents gbNivel As GroupBox
    Friend WithEvents rbAlto As RadioButton
    Friend WithEvents rbMedio As RadioButton
    Friend WithEvents rbBajo As RadioButton
    Friend WithEvents gbSintomas As GroupBox
    Friend WithEvents rbFatiga As RadioButton
    Friend WithEvents rbDoloresMusculares As RadioButton
    Friend WithEvents rbFiebre As RadioButton
    Friend WithEvents rbGanasDeVomitar As RadioButton
    Friend WithEvents rbMareado As RadioButton
    Friend WithEvents tabBajo As TabPage
    Friend WithEvents lblResultado As Label
    Friend WithEvents tabChequeo As TabPage
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rbDolorenunOrgano As RadioButton
End Class
