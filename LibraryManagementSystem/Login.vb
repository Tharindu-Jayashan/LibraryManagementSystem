Imports System.Data.SqlClient
Public Class Login

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Application.Exit()

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

        Dim Obj = New AdminLogin
        Obj.Show()
        Me.Hide()

    End Sub

    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Tharindu Jayashan\Documents\LibraryDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")


    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click

        If txtusername.Text = "" Then
            MsgBox("Enter the Librarian Name")

        ElseIf txtpswd.Text = "" Then
            MsgBox("Enter the Password")

        Else
            Con.Open()
            Dim query = "select * from LibrarianTbl where LibName = '" & txtusername.Text & "' and LibPass = '" & txtpswd.Text & "'"
            Dim cmd = New SqlCommand(query, Con)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count

            If a = 0 Then
                MsgBox("Wrong Username or Password")

            Else
                Dim Obj = New MainForm
                Obj.Show()
                Me.Hide()

            End If

            Con.Close()

        End If

    End Sub
End Class