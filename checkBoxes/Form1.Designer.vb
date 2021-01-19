<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkRice = New System.Windows.Forms.CheckBox()
        Me.chkPancakes = New System.Windows.Forms.CheckBox()
        Me.btnEat = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.chkBatteries = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkBatteries)
        Me.GroupBox1.Controls.Add(Me.chkRice)
        Me.GroupBox1.Controls.Add(Me.chkPancakes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7)
        Me.GroupBox1.Size = New System.Drawing.Size(232, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Breakfast"
        '
        'chkRice
        '
        Me.chkRice.AutoSize = True
        Me.chkRice.Location = New System.Drawing.Point(21, 87)
        Me.chkRice.Name = "chkRice"
        Me.chkRice.Size = New System.Drawing.Size(55, 20)
        Me.chkRice.TabIndex = 2
        Me.chkRice.Text = "Rice"
        Me.chkRice.UseVisualStyleBackColor = True
        '
        'chkPancakes
        '
        Me.chkPancakes.AutoSize = True
        Me.chkPancakes.Location = New System.Drawing.Point(21, 48)
        Me.chkPancakes.Name = "chkPancakes"
        Me.chkPancakes.Size = New System.Drawing.Size(88, 20)
        Me.chkPancakes.TabIndex = 1
        Me.chkPancakes.Text = "Pancakes"
        Me.chkPancakes.UseVisualStyleBackColor = True
        '
        'btnEat
        '
        Me.btnEat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEat.Location = New System.Drawing.Point(16, 202)
        Me.btnEat.Name = "btnEat"
        Me.btnEat.Size = New System.Drawing.Size(75, 26)
        Me.btnEat.TabIndex = 1
        Me.btnEat.Text = "EAT!"
        Me.btnEat.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(13, 292)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(49, 16)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "Result:"
        '
        'chkBatteries
        '
        Me.chkBatteries.AutoSize = True
        Me.chkBatteries.Location = New System.Drawing.Point(127, 48)
        Me.chkBatteries.Name = "chkBatteries"
        Me.chkBatteries.Size = New System.Drawing.Size(80, 20)
        Me.chkBatteries.TabIndex = 3
        Me.chkBatteries.Text = "Batteries"
        Me.chkBatteries.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 410)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnEat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRice As System.Windows.Forms.CheckBox
    Friend WithEvents chkPancakes As System.Windows.Forms.CheckBox
    Friend WithEvents btnEat As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents chkBatteries As System.Windows.Forms.CheckBox

End Class
