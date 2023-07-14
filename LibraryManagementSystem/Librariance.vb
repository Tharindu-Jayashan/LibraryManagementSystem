Imports System.Data.SqlClient
Public Class Librariance

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Application.Exit()

    End Sub

    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Tharindu Jayashan\Documents\LibraryDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub DisplayLibrian()

        Try

        Con.Open()
        Dim query = "select * from LibrarianTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        LibrianceDGV.DataSource = ds.Tables(0)

            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Try

        If txtlbid.Text = " " Or txtlbname.Text = "" Or txtlbphone.Text = "" Or txtlbpswd.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "insert into LibrarianTbl values( '" & txtlbid.Text & "' ,'" & txtlbname.Text & "','" & txtlbphone.Text & "','" & txtlbpswd.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librian Saved")

            Con.Close()

                DisplayLibrian()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Dim key = 0

    Private Sub LibrianceDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles LibrianceDGV.CellMouseClick


        Dim row As DataGridViewRow = LibrianceDGV.Rows(e.RowIndex)
        txtlbid.Text = row.Cells(0).Value.ToString
        txtlbname.Text = row.Cells(1).Value.ToString
        txtlbphone.Text = row.Cells(2).Value.ToString
        txtlbpswd.Text = row.Cells(3).Value.ToString
       

        If txtlbid.Text = "" Then
            key = 0

        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub Librariance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DisplayLibrian()

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click

        Try
            Con.Open()
            Dim query = "delete from LibrarianTbl where LibID =" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librian Deleted")

            Con.Close()

            DisplayLibrian()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

        Try
            Con.Open()
            Dim query = "update LibrarianTbl set LibID ='" & txtlbid.Text & " ',LibName='" & txtlbname.Text & "',LibPhone='" & txtlbphone.Text & "', LibPass='" & txtlbpswd.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librian Edited")

            Con.Close()

            DisplayLibrian()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click

        txtlbid.Text = ""
        txtlbname.Text = ""
        txtlbphone.Text = ""
        txtlbpswd.Text = ""

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click

        Dim Obj = New Login
        Obj.Show()
        Me.Hide()


    End Sub
End Class