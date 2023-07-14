Imports System.Data.SqlClient
Public Class Books

    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Tharindu Jayashan\Documents\LibraryDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub DisplayBook()

        Try

            Con.Open()
            Dim query = "select * from BookTbl"
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            booksDGV.DataSource = ds.Tables(0)

            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Try

            If txtbid.Text = "" Or txtbname.Text = "" Or txtauthor.Text = "" Or txtqty.Text = "" Or txtprice.Text = "" Or txtpublisher.Text = "" Then
                MsgBox("Missing Information")
            Else
                Con.Open()
                Dim query = "insert into BookTbl values('" & txtbid.Text & "','" & txtbname.Text & "','" & txtauthor.Text & "','" & txtpublisher.Text & "','" & txtprice.Text & "' ,'" & txtqty.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Book Saved")

                Con.Close()

                DisplayBook()


            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Books_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayBook()

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub reset()
        txtbid.Text = " "
        txtbname.Text = " "
        txtauthor.Text = " "
        txtpublisher.Text = " "
        txtprice.Text = " "
        txtqty.Text = " "
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()

    End Sub

    Dim key = 0

    Private Sub booksDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles booksDGV.CellMouseClick

        Try
            Dim row As DataGridViewRow = booksDGV.Rows(e.RowIndex)
            txtbid.Text = row.Cells(0).Value.ToString
            txtbname.Text = row.Cells(1).Value.ToString
            txtauthor.Text = row.Cells(2).Value.ToString
            txtpublisher.Text = row.Cells(3).Value.ToString
            txtprice.Text = row.Cells(4).Value.ToString
            txtqty.Text = row.Cells(5).Value.ToString

            If txtbid.Text = "" Then
                key = 0

            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click

        Try
            Con.Open()
            Dim query = "delete from BookTbl where BId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted")

            Con.Close()

            DisplayBook()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

        Try
            Con.Open()
            Dim query = "update BookTbl set BId ='" & txtbid.Text & " ',BName='" & txtbname.Text & "',BAuthor='" & txtauthor.Text & "',BPublisher='" & txtpublisher.Text & "',BPrice='" & txtprice.Text & "' ,BQty='" & txtqty.Text & "' where BId= " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Edited")

            Con.Close()

            DisplayBook()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try


    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Dim Obj = New MainForm
        Obj.Show()
        Me.Hide()
    End Sub
End Class