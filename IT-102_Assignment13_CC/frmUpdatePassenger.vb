Imports System.Data.SQLite
Imports System.IO

Public Class frmUpdatePassenger
    Private Sub frmUpdatePassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))
        Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strStateQuery As String =
                "SELECT intStateID, strState
                FROM TStates;"
            Using command As New SQLiteCommand(strStateQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                cboState.DataSource = dataTable
                cboState.DisplayMember = "strState"
                cboState.ValueMember = "intStateID"

            End Using

            Dim strPassengerQuery As String =
                "SELECT intPassengerID, strFirstName || ' ' || strLastName As strFullName
                FROM TPassengers;"
            Using command As New SQLiteCommand(strPassengerQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cboPassengers.DataSource = dataTable
                cboPassengers.DisplayMember = "strFullName"
                cboPassengers.ValueMember = "intPassengerID"

            End Using
        End Using
    End Sub

    Private Sub cboPassengers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPassengers.SelectedIndexChanged
        If TypeOf cboPassengers.SelectedValue Is DataRowView OrElse cboPassengers.SelectedValue Is Nothing Then
            Exit Sub
        End If

        Dim databasePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))
        Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strPassengerQuery As String =
                $"SELECT intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail
                FROM TPassengers
                WHERE intPassengerID = {cboPassengers.SelectedValue}"
            Using command As New SQLiteCommand(strPassengerQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    reader.Read()
                    txtFirstName.Text = reader.GetString(1)
                    txtLastName.Text = reader.GetString(2)
                    txtAddress.Text = reader.GetString(3)
                    txtCity.Text = reader.GetString(4)
                    cboState.SelectedValue = reader.GetInt32(5)
                    txtZipCode.Text = reader.GetString(6)
                    txtPhoneNumber.Text = reader.GetString(7)
                    txtEmail.Text = reader.GetString(8)

                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim intStateID As Integer
        Dim strZipCode As String
        Dim strPhoneNumber As String
        Dim strEmail As String
        Dim intPassengerID As Integer

        intStateID = cboState.SelectedValue
        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        strAddress = txtAddress.Text
        strCity = txtCity.Text
        strZipCode = txtZipCode.Text
        strPhoneNumber = txtPhoneNumber.Text
        strEmail = txtEmail.Text
        intPassengerID = cboPassengers.SelectedValue

        Dim strUpdateQuery As String =
            $"UPDATE TPassengers
            SET strFirstName = '{strFirstName}',
                strLastName = '{strLastName}',
                strAddress = '{strAddress}',
                strCity = '{strCity}',
                intStateID = {intStateID},
                strZip = '{strZipCode}',
                strPhoneNumber = '{strPhoneNumber}',
                strEmail = '{strEmail}'
            WHERE intPassengerID = {intPassengerID}"

        MessageBox.Show("Passenger information updated successfully.")

        Dim databasePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))
        Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using command As New SQLiteCommand(strUpdateQuery, conn)
                command.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class