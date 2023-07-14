Imports System.Data.SqlClient

Public Class IssueBooks

    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Tharindu Jayashan\Documents\LibraryDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub DisplayIssueDetails()

        Try
            Con.Open()
            Dim query = "select * from IssueTbl"
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            IssueDGV.DataSource = ds.Tables(0)

            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub FillStudent()
        Try
            Con.Open()
            Dim query = "Select * From StudentTbl "
            Dim cmd As New SqlCommand(query, Con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim Tbl As New DataTable()
            adapter.Fill(Tbl)
            cmbstid.DataSource = Tbl
            cmbstid.DisplayMember = "StId"
            cmbstid.ValueMember = "StId"
            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub GetStudentName()
        Try
            Con.Open()

            Dim query = "Select * From StudentTbl where StId = " & cmbstid.SelectedValue.ToString() & ""
            Dim cmd = New SqlCommand(query, Con)
            Dim dt As New DataTable()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                txtisname.Text = "" + reader(1).ToString()
            End While

            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub GetBooktName()

        Try

        Con.Open()

        Dim query = "Select * From BookTbl where BId = " & cmbbkid.SelectedValue.ToString() & ""
        Dim cmd = New SqlCommand(query, Con)
        Dim dt As New DataTable()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            txtbkname.Text = "" + reader(1).ToString()
        End While

            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub FillBook()

        Try
            Con.Open()
            Dim query = "Select * From BookTbl "
            Dim cmd As New SqlCommand(query, Con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim Tbl As New DataTable()
            adapter.Fill(Tbl)
            cmbbkid.DataSource = Tbl
            cmbbkid.DisplayMember = "BId"
            cmbbkid.ValueMember = "BId"
            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub


    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

        Try

            Con.Open()
            Dim query = "update IssueTbl set INum ='" & txtissueid.Text & " ',StId='" & cmbstid.Text & "',StName='" & txtisname.Text & "',BookId='" & cmbbkid.Text & "',BookName='" & txtbkname.Text & "' ,IssueDate='" & bkissuedate.Value.Date & "' where INum = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Issue Details Edited")

            Con.Close()
            DisplayIssueDetails()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub IssueBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DisplayIssueDetails()
        FillStudent()
        FillBook()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Application.Exit()

    End Sub

    Private Sub cmbstid_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstid.SelectionChangeCommitted

        GetStudentName()

    End Sub

    Private Sub cmbbkid_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbkid.SelectionChangeCommitted

        GetBooktName()

    End Sub

    Private Sub cmbbkid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbkid.SelectedIndexChanged

    End Sub


    Dim Num = 0
    Private Sub CountBook()

        Con.Open()
        Dim query = "select count(*) from IssueTbl where StId = " & cmbstid.SelectedValue.ToString & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        Num = cmd.ExecuteScalar
        Con.Close()
    End Sub


    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click

        CountBook()

        If txtissueid.Text = "" Or cmbstid.Text = "" Or txtbkname.Text = "" Or cmbbkid.Text = "" Or txtbkname.Text = "" Then
            MsgBox("Missing Information")

        ElseIf Num = 5 Then
            MsgBox("No more than 5 book issued")

        Else

            Try

                Con.Open()
                Dim query = "insert into IssueTbl values('" & txtissueid.Text & "','" & cmbstid.SelectedValue.ToString() & "','" & txtisname.Text & "','" & cmbbkid.SelectedValue.ToString() & "','" & txtbkname.Text & "','" & bkissuedate.Value.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Book Issued")

                Con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If

        DisplayIssueDetails()

    End Sub

    Private Sub reset()

        txtissueid.Text = ""
        txtbkname.Text = ""
        txtisname.Text = ""
        cmbbkid.Text = ""
        cmbstid.Text = ""


    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click

        reset()

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click

        Dim Obj = New MainForm
        Obj.Show()
        Me.Hide()

    End Sub

    Dim key = 0

    Private Sub IssueDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles IssueDGV.CellMouseClick


        Dim row As DataGridViewRow = IssueDGV.Rows(e.RowIndex)
        txtissueid.Text = row.Cells(0).Value.ToString
        cmbstid.Text = row.Cells(1).Value.ToString
        txtisname.Text = row.Cells(2).Value.ToString
        cmbbkid.Text = row.Cells(3).Value.ToString
        txtbkname.Text = row.Cells(4).Value.ToString
        bkissuedate.Text = row.Cells(5).Value.ToString

        If txtissueid.Text = "" Then
            key = 0

        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub
End Class