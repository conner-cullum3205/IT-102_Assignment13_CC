<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAddPassenger = New System.Windows.Forms.Button()
        Me.btnShowPassenger = New System.Windows.Forms.Button()
        Me.btnUpdatePassenger = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddPassenger
        '
        Me.btnAddPassenger.Location = New System.Drawing.Point(27, 39)
        Me.btnAddPassenger.Name = "btnAddPassenger"
        Me.btnAddPassenger.Size = New System.Drawing.Size(147, 52)
        Me.btnAddPassenger.TabIndex = 0
        Me.btnAddPassenger.Text = "Add Passenger"
        Me.btnAddPassenger.UseVisualStyleBackColor = True
        '
        'btnShowPassenger
        '
        Me.btnShowPassenger.Location = New System.Drawing.Point(27, 117)
        Me.btnShowPassenger.Name = "btnShowPassenger"
        Me.btnShowPassenger.Size = New System.Drawing.Size(147, 52)
        Me.btnShowPassenger.TabIndex = 1
        Me.btnShowPassenger.Text = "Show Passenger"
        Me.btnShowPassenger.UseVisualStyleBackColor = True
        '
        'btnUpdatePassenger
        '
        Me.btnUpdatePassenger.Location = New System.Drawing.Point(27, 195)
        Me.btnUpdatePassenger.Name = "btnUpdatePassenger"
        Me.btnUpdatePassenger.Size = New System.Drawing.Size(147, 52)
        Me.btnUpdatePassenger.TabIndex = 2
        Me.btnUpdatePassenger.Text = "Update Passenger"
        Me.btnUpdatePassenger.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(213, 201)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 41)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 283)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdatePassenger)
        Me.Controls.Add(Me.btnShowPassenger)
        Me.Controls.Add(Me.btnAddPassenger)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddPassenger As Button
    Friend WithEvents btnShowPassenger As Button
    Friend WithEvents btnUpdatePassenger As Button
    Friend WithEvents btnExit As Button
End Class
