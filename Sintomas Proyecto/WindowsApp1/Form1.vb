Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim nombre As String = txtNombre.Text
        Dim sintoma As String = ""
        Dim nivel As String = ""

        If rbMareado.Checked Then
            sintoma = "mareado"
        ElseIf rbGanasDeVomitar.Checked Then
            sintoma = "ganas de vomitar"
        ElseIf rbFiebre.Checked Then
            sintoma = "fiebre"
        ElseIf rbDoloresMusculares.Checked Then
            sintoma = "dolores musculares"
        ElseIf rbFatiga.Checked Then
            sintoma = "fatiga"
        ElseIf rbDolorenunOrgano.Checked Then
            sintoma = "Dolor en un Organo"
        End If

        If rbBajo.Checked Then
            nivel = "bajo"
        ElseIf rbMedio.Checked Then
            nivel = "medio"
        ElseIf rbAlto.Checked Then
            nivel = "alto"
        End If

        Dim resultado As String = ""

        Select Case sintoma
            Case "mareado"
                Select Case nivel
                    Case "bajo"
                        resultado = "Descanse en casa."
                    Case "medio"
                        resultado = "Tome un acetaminofén y descanse."
                    Case "alto"
                        resultado = "Necesita hospitalización."
                End Select

            Case "ganas de vomitar"
                Select Case nivel
                    Case "bajo"
                        resultado = "Oler alcohol."
                    Case "medio"
                        resultado = "Tomar una pastilla gástrica."
                    Case "alto"
                        resultado = "Tomar una pastilla y estar en supervisión."
                End Select
            Case "fiebre"
                Select Case nivel
                    Case "bajo"
                        resultado = "Tomar una aspirina."
                    Case "medio"
                        resultado = "Aplicar una inyección."
                    Case "alto"
                        resultado = "Necesita hospitalización."
                End Select
            Case "dolores musculares"
                Select Case nivel
                    Case "bajo"
                        resultado = "Aplicar una crema."
                    Case "medio"
                        resultado = "Tomar un calmante."
                    Case "alto"
                        resultado = "Recibir sesiones de masajes."
                End Select
            Case "fatiga"
                Select Case nivel
                    Case "bajo"
                        resultado = "Proporcionar oxígeno."
                    Case "medio"
                        resultado = "Usar un respirador."
                    Case "alto"
                        resultado = "Necesita hospitalización."
                End Select
            Case "Dolor en un Organo"
                Select Case nivel
                    Case "bajo"
                        resultado = "Descanse en casa y tome un analgésico suave."
                    Case "medio"
                        resultado = "Consulte a un médico para una evaluación exhaustiva. Evite el esfuerzo físico y tome un analgésico."
                    Case "alto"
                        resultado = "Busque atención médica de inmediato."
                End Select
        End Select

        lblResultado.Text = $"Estimado(a) {nombre}, basado en su síntoma de {sintoma} y su nivel de molestia {nivel}, se le recomienda: {resultado}"

        ' Asegurarse de establecer el valor máximo de ProgressBar1 (puede ser 100 o cualquier otro valor deseado)
        ProgressBar1.Maximum = 100

        ' Establecer el valor de ProgressBar1 en función del nivel
        Select Case nivel
            Case "bajo"
                ProgressBar1.Value = 30
            Case "medio"
                ProgressBar1.Value = 60
            Case "alto"
                ProgressBar1.Value = 100
        End Select

        ' Mostrar la barra de progreso
        ProgressBar1.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
    End Sub

End Class
