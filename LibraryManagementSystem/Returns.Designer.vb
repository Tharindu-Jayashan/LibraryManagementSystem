<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Returns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Returns))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.returnissuedate = New System.Windows.Forms.DateTimePicker()
        Me.cmbreturnbkid = New System.Windows.Forms.ComboBox()
        Me.cmbreturnstid = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtreturnbkname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtreturnstname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.txtfine = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.returndate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.IssueDGV = New System.Windows.Forms.DataGridView()
        Me.returnDGV = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.txtreturnid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IssueDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(170, 470)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.returnissuedate)
        Me.Panel1.Controls.Add(Me.cmbreturnbkid)
        Me.Panel1.Controls.Add(Me.cmbreturnstid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtreturnbkname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtreturnstname)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(175, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 145)
        Me.Panel1.TabIndex = 32
        '
        'returnissuedate
        '
        Me.returnissuedate.Location = New System.Drawing.Point(456, 45)
        Me.returnissuedate.Name = "returnissuedate"
        Me.returnissuedate.Size = New System.Drawing.Size(117, 20)
        Me.returnissuedate.TabIndex = 31
        '
        'cmbreturnbkid
        '
        Me.cmbreturnbkid.FormattingEnabled = True
        Me.cmbreturnbkid.Location = New System.Drawing.Point(234, 44)
        Me.cmbreturnbkid.Name = "cmbreturnbkid"
        Me.cmbreturnbkid.Size = New System.Drawing.Size(75, 21)
        Me.cmbreturnbkid.TabIndex = 29
        '
        'cmbreturnstid
        '
        Me.cmbreturnstid.FormattingEnabled = True
        Me.cmbreturnstid.Location = New System.Drawing.Point(7, 44)
        Me.cmbreturnstid.Name = "cmbreturnstid"
        Me.cmbreturnstid.Size = New System.Drawing.Size(81, 21)
        Me.cmbreturnstid.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Student Id"
        '
        'txtreturnbkname
        '
        Me.txtreturnbkname.Location = New System.Drawing.Point(333, 45)
        Me.txtreturnbkname.Name = "txtreturnbkname"
        Me.txtreturnbkname.Size = New System.Drawing.Size(106, 20)
        Me.txtreturnbkname.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(122, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(230, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Book Id"
        '
        'txtreturnstname
        '
        Me.txtreturnstname.Location = New System.Drawing.Point(105, 44)
        Me.txtreturnstname.Name = "txtreturnstname"
        Me.txtreturnstname.Size = New System.Drawing.Size(113, 20)
        Me.txtreturnstname.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(330, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Book Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(455, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Issue Date"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(105, 87)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 29)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(122, 138)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(75, 27)
        Me.btncalculate.TabIndex = 35
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'txtfine
        '
        Me.txtfine.Location = New System.Drawing.Point(49, 112)
        Me.txtfine.Name = "txtfine"
        Me.txtfine.Size = New System.Drawing.Size(111, 20)
        Me.txtfine.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(3, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 19)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Fine"
        '
        'returndate
        '
        Me.returndate.Location = New System.Drawing.Point(49, 28)
        Me.returndate.Name = "returndate"
        Me.returndate.Size = New System.Drawing.Size(111, 20)
        Me.returndate.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(3, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Return Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(367, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Return Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(286, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Book Issued"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(739, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 25)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Book Returned"
        '
        'IssueDGV
        '
        Me.IssueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssueDGV.Location = New System.Drawing.Point(189, 223)
        Me.IssueDGV.Name = "IssueDGV"
        Me.IssueDGV.Size = New System.Drawing.Size(419, 213)
        Me.IssueDGV.TabIndex = 35
        '
        'returnDGV
        '
        Me.returnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.returnDGV.Location = New System.Drawing.Point(631, 223)
        Me.returnDGV.Name = "returnDGV"
        Me.returnDGV.Size = New System.Drawing.Size(405, 213)
        Me.returnDGV.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1033, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(991, 442)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 29)
        Me.btnback.TabIndex = 38
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'txtreturnid
        '
        Me.txtreturnid.Location = New System.Drawing.Point(49, 73)
        Me.txtreturnid.Name = "txtreturnid"
        Me.txtreturnid.Size = New System.Drawing.Size(111, 20)
        Me.txtreturnid.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(3, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 19)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Return Id"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtreturnid)
        Me.Panel2.Controls.Add(Me.btncalculate)
        Me.Panel2.Controls.Add(Me.returndate)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtfine)
        Me.Panel2.Location = New System.Drawing.Point(771, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(208, 170)
        Me.Panel2.TabIndex = 39
        '
        'Returns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1068, 471)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.returnDGV)
        Me.Controls.Add(Me.IssueDGV)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Returns"
        Me.Text = "Returns"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IssueDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtfine As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents returndate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents returnissuedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbreturnbkid As System.Windows.Forms.ComboBox
    Friend WithEvents cmbreturnstid As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtreturnbkname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtreturnstname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents IssueDGV As System.Windows.Forms.DataGridView
    Friend WithEvents returnDGV As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtreturnid As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
