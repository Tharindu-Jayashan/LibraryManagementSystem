Imports System.Data.SqlClient
Public Class Student

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsid.TextChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Tharindu Jayashan\Documents\LibraryDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub DisplayStudents()

        Try
            Con.Open()
            Dim query = "select * from StudentTbl"
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            StudentDGV.DataSource = ds.Tables(0)

            Con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Try
            If txtsid.Text = "" Or txtsname.Text = "" Or txtsdepartment.Text = "" Or cmbsemester.Text = "" Or txtphone.Text = "" Then
                MsgBox("Missing Information")
            Else
                Con.Open()
                Dim query = "insert into StudentTbl values('" & txtsid.Text & "','" & txtsname.Text & "','" & txtsdepartment.Text & "','" & cmbsemester.Text & "','" & txtphone.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Saved")

                Con.Close()

                DisplayStudents()


            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub

    Private Sub Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayStudents()

    End Sub

    Private Sub StudentDGV_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StudentDGV.MouseClick

    End Sub

    Dim key = 0

    Private Sub StudentDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles StudentDGV.CellMouseClick

        Dim row As DataGridViewRow = StudentDGV.Rows(e.RowIndex)
        txtsid.Text = row.Cells(0).Value.ToString
        txtsname.Text = row.Cells(1).Value.ToString
        txtsdepartment.Text = row.Cells(2).Value.ToString
        cmbsemester.Text = row.Cells(3).Value.ToString
        txtphone.Text = row.Cells(4).Value.ToString

        If txtsid.Text = "" Then
            key = 0

        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click

        Try
            Con.Open()
            Dim query = "delete from StudentTbl where StId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Student Deleted")

            Con.Close()

            DisplayStudents()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

        Try
            Con.Open()
            Dim query = "update StudentTbl set StId ='" & txtsid.Text & " ',StName='" & txtsname.Text & "',StDep='" & txtsdepartment.Text & "',StSem='" & cmbsemester.SelectedItem.ToString() & "',StPhone='" & txtphone.Text & "' where StId= " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Student Edited")

            Con.Close()

            DisplayStudents()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click

        txtsid.Text = ""
        txtsname.Text = ""
        txtsdepartment.Text = ""
        cmbsemester.Text = ""
        txtphone.Text = ""

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim Obj = New MainForm
        Obj.Show()
        Me.Hide()

    End Sub
End Class