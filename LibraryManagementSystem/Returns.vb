Imports System.Data.SqlClient
Public Class Returns


    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Tharindu Jayashan\Documents\LibraryDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub DisplayBook()

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

    Private Sub DisplayReturnedBook()

        Try
            Con.Open()
            Dim query = "select * from ReturnTbl"
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            returnDGV.DataSource = ds.Tables(0)

            Con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub RemoveFromIssue()

        Try

            Con.Open()
            Dim query = "delete from IssueTbl where INum =" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Issue Removed")
            Con.Close()

            DisplayBook()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtreturnid.Text = "" Or cmbreturnstid.Text = "" Or txtreturnstname.Text = "" Or cmbreturnbkid.Text = "" Or txtreturnbkname.Text = "" Or returnissuedate.Text = "" Or returndate.Text = "" Or txtfine.Text = "" Then


            MsgBox("Missing Information")

        Else


            Try

                Con.Open()
                Dim query = "insert into ReturnTbl values('" & txtreturnid.Text & "','" & cmbreturnstid.Text & "','" & txtreturnstname.Text & "','" & cmbreturnbkid.Text & "','" & txtreturnbkname.Text & "','" & returnissuedate.Value.Date & "','" & returndate.Value.Date & "','" & txtfine.Text.ToString & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Book returned")

                Con.Close()

                DisplayReturnedBook()
                RemoveFromIssue()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Application.Exit()

    End Sub

    Private Sub Returns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DisplayBook()
        DisplayReturnedBook()

    End Sub

    Dim key = 0

    Private Sub IssueDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles IssueDGV.CellMouseClick

        Dim row As DataGridViewRow = IssueDGV.Rows(e.RowIndex)

        cmbreturnstid.Text = row.Cells(1).Value.ToString
        txtreturnstname.Text = row.Cells(2).Value.ToString
        cmbreturnbkid.Text = row.Cells(3).Value.ToString
        txtreturnbkname.Text = row.Cells(4).Value.ToString
        returnissuedate.Text = row.Cells(5).Value.ToString

        If cmbreturnstid.Text = "" Then
            key = 0

        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If


    End Sub

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click

        Try
            Dim Dif As TimeSpan
            Dim Fine As Integer
            Dif = returndate.Value.Date - returnissuedate.Value.Date
            Dim Days = Dif.Days

            If Days <= 20 Then
                Fine = 0
                txtfine.Text = "0"

            Else
                Fine = Days - 20
                txtfine.Text = Convert.ToString(Fine * 50)


            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        txtreturnid.Text = ""
        cmbreturnstid.Text = ""
        txtreturnstname.Text = ""
        cmbreturnbkid.Text = ""
        txtreturnbkname.Text = ""
        returnissuedate.Text = ""
        returndate.Text = ""
        txtfine.Text = ""

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click

        Dim Obj = New MainForm
        Obj.Show()
        Me.Hide()

    End Sub
End Class