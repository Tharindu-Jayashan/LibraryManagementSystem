Public Class AdminLogin

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtpswd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadminpswd.TextChanged

    End Sub

    Private Sub btnadminlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadminlogin.Click

        If txtadminpswd.Text = "" Then
            MsgBox("Enter The Admin Password")

        ElseIf txtadminpswd.Text = "1111" Then
            Dim Obj = New Librariance
            Obj.Show()
            Me.Hide()

        Else
            MsgBox("Wrong Password")
            txtadminpswd.Text = ""

        End If

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

        Dim Obj = New Login
        Obj.Show()
        Me.Hide()

    End Sub
End Class