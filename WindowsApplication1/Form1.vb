Public Class Form1
    Dim saldoactu As Double = 1500

    Private Sub botonCerrar_Click(sender As Object, e As EventArgs) Handles botonCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnenviar_Click(sender As Object, e As EventArgs) Handles btnenviar.Click


        Dim cuentao As String = txtorigen.Text
        Dim cuentde As String = txtdestino.Text
        Dim concepto As String = txtconcepto.Text
        Dim importe As Double = Double.Parse(txtimporte.Text)
        Dim digitos As String = txtultimosdigitos.Text

        If importe > saldoactu Then
            MsgBox("No se puede Tranferir, no cuenta con saldo suficiente...")
        Else
            saldoactu = saldoactu - importe
            MsgBox("Se transfirio " & concepto)
            MsgBox("Cuenta: " & cuentde)

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saldoactu As Double = 1500
        lblsaldo.Text = saldoactu.ToString("S/. ##00.00")
    End Sub
End Class
