<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtec = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.Label()
        Me.txtet = New System.Windows.Forms.Label()
        Me.txtphone = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(536, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 42)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "RECEIPT"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(765, 368)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtec
        '
        Me.txtec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtec.AutoSize = True
        Me.txtec.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtec.Location = New System.Drawing.Point(392, 192)
        Me.txtec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtec.Name = "txtec"
        Me.txtec.Size = New System.Drawing.Size(138, 25)
        Me.txtec.TabIndex = 37
        Me.txtec.Text = "Event Code:"
        '
        'txtname
        '
        Me.txtname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtname.AutoSize = True
        Me.txtname.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(392, 230)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(78, 25)
        Me.txtname.TabIndex = 38
        Me.txtname.Text = "Name:"
        '
        'txtet
        '
        Me.txtet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtet.AutoSize = True
        Me.txtet.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtet.Location = New System.Drawing.Point(395, 303)
        Me.txtet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtet.Name = "txtet"
        Me.txtet.Size = New System.Drawing.Size(140, 25)
        Me.txtet.TabIndex = 39
        Me.txtet.Text = "Event Type:"
        '
        'txtphone
        '
        Me.txtphone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtphone.AutoSize = True
        Me.txtphone.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(392, 269)
        Me.txtphone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(120, 25)
        Me.txtphone.TabIndex = 40
        Me.txtphone.Text = "Phone no:"
        '
        'txttotal
        '
        Me.txttotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txttotal.AutoSize = True
        Me.txttotal.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(395, 348)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(75, 25)
        Me.txttotal.TabIndex = 46
        Me.txttotal.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(393, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Customer code:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Location = New System.Drawing.Point(563, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 48
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(701, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 33)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1124, 478)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtet)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtec)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Receipt"
        Me.Text = "Receipt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtec As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.Label
    Friend WithEvents txtet As System.Windows.Forms.Label
    Friend WithEvents txtphone As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
