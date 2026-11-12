Imports System.Data.SQLite
Imports System.IO

Public Class frmShowPassenger
    Private Sub frmShowPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))
        Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"
        Dim strQuery As String =
            "SELECT strFirstName,
                    strLastName
            FROM TPassengers;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strFirstName As String = reader.GetString(0)
                        Dim strLastName As String = reader.GetString(1)
                        Dim strFullName As String = strFirstName & " " & strLastName
                        cboPassengers.Items.Add(strFullName)

                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cboPassengers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPassengers.SelectedIndexChanged
        Dim databasePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))
        Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"
        Dim strQuery As String =
            "SELECT TF.strFlightNumber,
                    TF.dtmFlightDate,
                    TF.dtmTimeOfDeparture,
                    TF.dtmTimeOfLanding
            FROM TFlights As TF
            JOIN TFlightPassengers As TFP
                ON TF.intFlightID = TFP.intFlightID
            JOIN TPassengers As TP
                ON TFP.intPassengerID = TP.intPassengerID
            WHERE TP.strFirstName || ' ' || TP.strLastName = '" & cboPassengers.SelectedItem.ToString() & "';"

        Using conn As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(strQuery, conn)
                conn.Open()
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    lstFlights.Items.Clear()
                    While reader.Read()
                        Dim strFlightNumber As String = reader.GetString(0)
                        Dim dtmFlightDate As String = reader.GetString(1)
                        Dim dtmTimeOfDeparture As String = reader.GetString(2)
                        Dim dtmTimeOfLanding As String = reader.GetString(3)
                        lstFlights.Items.Add("Flight Number: " & strFlightNumber & ", Date: " & dtmFlightDate & ", Departure: " & dtmTimeOfDeparture & ", Landing: " & dtmTimeOfLanding)

                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class