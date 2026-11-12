Public Class frmMain
    Private Sub btnAddPassenger_Click(sender As Object, e As EventArgs) Handles btnAddPassenger.Click
        Dim frmAddPassenger As New frmAddPassenger
        frmAddPassenger.ShowDialog()

    End Sub

    Private Sub btnShowPassenger_Click(sender As Object, e As EventArgs) Handles btnShowPassenger.Click
        Dim frmShowPassenger As New frmShowPassenger
        frmShowPassenger.ShowDialog()

    End Sub

    Private Sub btnUpdatePassenger_Click(sender As Object, e As EventArgs) Handles btnUpdatePassenger.Click
        Dim frmUpdatePassenger As New frmUpdatePassenger
        frmUpdatePassenger.ShowDialog()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
