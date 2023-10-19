<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CloseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CloseForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LblUsername = New System.Windows.Forms.ToolStripLabel()
        Me.LblType = New System.Windows.Forms.ToolStripLabel()
        Me.LblCheckerName = New System.Windows.Forms.Label()
        Me.TxtCheckerRegistration = New System.Windows.Forms.TextBox()
        Me.LblCheckerRegistration = New System.Windows.Forms.Label()
        Me.TxtDepartment = New System.Windows.Forms.TextBox()
        Me.LblDepartment = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtLine = New System.Windows.Forms.TextBox()
        Me.LblLine = New System.Windows.Forms.Label()
        Me.TxtCheckerName = New System.Windows.Forms.TextBox()
        Me.CmbSupportList = New System.Windows.Forms.ComboBox()
        Me.LblSupportList = New System.Windows.Forms.Label()
        Me.LblIssueDate = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAction = New System.Windows.Forms.RichTextBox()
        Me.LblAction = New System.Windows.Forms.Label()
        Me.TxtProblem = New System.Windows.Forms.RichTextBox()
        Me.LblProblem = New System.Windows.Forms.Label()
        Me.TxtIssueDate = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmbCategory = New System.Windows.Forms.ComboBox()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblUsername, Me.LblType})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 506)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(549, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LblUsername
        '
        Me.LblUsername.Font = New System.Drawing.Font("Source Sans Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(63, 22)
        Me.LblUsername.Text = "Username"
        '
        'LblType
        '
        Me.LblType.Font = New System.Drawing.Font("Source Sans Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(34, 22)
        Me.LblType.Text = "Type"
        '
        'LblCheckerName
        '
        Me.LblCheckerName.AutoSize = True
        Me.LblCheckerName.Location = New System.Drawing.Point(18, 185)
        Me.LblCheckerName.Name = "LblCheckerName"
        Me.LblCheckerName.Size = New System.Drawing.Size(86, 17)
        Me.LblCheckerName.TabIndex = 7
        Me.LblCheckerName.Text = "Checker Name"
        '
        'TxtCheckerRegistration
        '
        Me.TxtCheckerRegistration.Enabled = False
        Me.TxtCheckerRegistration.Location = New System.Drawing.Point(15, 150)
        Me.TxtCheckerRegistration.Name = "TxtCheckerRegistration"
        Me.TxtCheckerRegistration.ReadOnly = True
        Me.TxtCheckerRegistration.Size = New System.Drawing.Size(186, 24)
        Me.TxtCheckerRegistration.TabIndex = 6
        '
        'LblCheckerRegistration
        '
        Me.LblCheckerRegistration.AutoSize = True
        Me.LblCheckerRegistration.Location = New System.Drawing.Point(15, 130)
        Me.LblCheckerRegistration.Name = "LblCheckerRegistration"
        Me.LblCheckerRegistration.Size = New System.Drawing.Size(119, 17)
        Me.LblCheckerRegistration.TabIndex = 5
        Me.LblCheckerRegistration.Text = "Checker Registration"
        '
        'TxtDepartment
        '
        Me.TxtDepartment.Enabled = False
        Me.TxtDepartment.Location = New System.Drawing.Point(15, 40)
        Me.TxtDepartment.Name = "TxtDepartment"
        Me.TxtDepartment.ReadOnly = True
        Me.TxtDepartment.Size = New System.Drawing.Size(189, 24)
        Me.TxtDepartment.TabIndex = 4
        '
        'LblDepartment
        '
        Me.LblDepartment.AutoSize = True
        Me.LblDepartment.Location = New System.Drawing.Point(15, 20)
        Me.LblDepartment.Name = "LblDepartment"
        Me.LblDepartment.Size = New System.Drawing.Size(73, 17)
        Me.LblDepartment.TabIndex = 3
        Me.LblDepartment.Text = "Department"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtLine)
        Me.GroupBox2.Controls.Add(Me.LblLine)
        Me.GroupBox2.Controls.Add(Me.TxtCheckerName)
        Me.GroupBox2.Controls.Add(Me.LblCheckerName)
        Me.GroupBox2.Controls.Add(Me.TxtCheckerRegistration)
        Me.GroupBox2.Controls.Add(Me.LblCheckerRegistration)
        Me.GroupBox2.Controls.Add(Me.TxtDepartment)
        Me.GroupBox2.Controls.Add(Me.LblDepartment)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 248)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'TxtLine
        '
        Me.TxtLine.Enabled = False
        Me.TxtLine.Location = New System.Drawing.Point(15, 93)
        Me.TxtLine.Name = "TxtLine"
        Me.TxtLine.ReadOnly = True
        Me.TxtLine.Size = New System.Drawing.Size(189, 24)
        Me.TxtLine.TabIndex = 10
        '
        'LblLine
        '
        Me.LblLine.AutoSize = True
        Me.LblLine.Location = New System.Drawing.Point(15, 73)
        Me.LblLine.Name = "LblLine"
        Me.LblLine.Size = New System.Drawing.Size(30, 17)
        Me.LblLine.TabIndex = 9
        Me.LblLine.Text = "Line"
        '
        'TxtCheckerName
        '
        Me.TxtCheckerName.Enabled = False
        Me.TxtCheckerName.Location = New System.Drawing.Point(18, 205)
        Me.TxtCheckerName.Name = "TxtCheckerName"
        Me.TxtCheckerName.ReadOnly = True
        Me.TxtCheckerName.Size = New System.Drawing.Size(186, 24)
        Me.TxtCheckerName.TabIndex = 8
        '
        'CmbSupportList
        '
        Me.CmbSupportList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSupportList.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSupportList.FormattingEnabled = True
        Me.CmbSupportList.Location = New System.Drawing.Point(16, 46)
        Me.CmbSupportList.Name = "CmbSupportList"
        Me.CmbSupportList.Size = New System.Drawing.Size(189, 28)
        Me.CmbSupportList.TabIndex = 2
        '
        'LblSupportList
        '
        Me.LblSupportList.AutoSize = True
        Me.LblSupportList.Location = New System.Drawing.Point(16, 26)
        Me.LblSupportList.Name = "LblSupportList"
        Me.LblSupportList.Size = New System.Drawing.Size(78, 17)
        Me.LblSupportList.TabIndex = 1
        Me.LblSupportList.Text = "Support Lists"
        '
        'LblIssueDate
        '
        Me.LblIssueDate.AutoSize = True
        Me.LblIssueDate.Location = New System.Drawing.Point(18, 26)
        Me.LblIssueDate.Name = "LblIssueDate"
        Me.LblIssueDate.Size = New System.Drawing.Size(62, 17)
        Me.LblIssueDate.TabIndex = 7
        Me.LblIssueDate.Text = "Issue Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAction)
        Me.GroupBox3.Controls.Add(Me.LblAction)
        Me.GroupBox3.Controls.Add(Me.TxtProblem)
        Me.GroupBox3.Controls.Add(Me.LblProblem)
        Me.GroupBox3.Controls.Add(Me.TxtIssueDate)
        Me.GroupBox3.Controls.Add(Me.LblIssueDate)
        Me.GroupBox3.Location = New System.Drawing.Point(242, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 447)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'txtAction
        '
        Me.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAction.Location = New System.Drawing.Point(18, 284)
        Me.txtAction.Multiline = False
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(264, 143)
        Me.txtAction.TabIndex = 12
        Me.txtAction.Text = ""
        '
        'LblAction
        '
        Me.LblAction.AutoSize = True
        Me.LblAction.Location = New System.Drawing.Point(15, 264)
        Me.LblAction.Name = "LblAction"
        Me.LblAction.Size = New System.Drawing.Size(42, 17)
        Me.LblAction.TabIndex = 11
        Me.LblAction.Text = "Action"
        '
        'TxtProblem
        '
        Me.TxtProblem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProblem.Enabled = False
        Me.TxtProblem.Location = New System.Drawing.Point(18, 102)
        Me.TxtProblem.Name = "TxtProblem"
        Me.TxtProblem.ReadOnly = True
        Me.TxtProblem.Size = New System.Drawing.Size(264, 150)
        Me.TxtProblem.TabIndex = 10
        Me.TxtProblem.Text = ""
        '
        'LblProblem
        '
        Me.LblProblem.AutoSize = True
        Me.LblProblem.Location = New System.Drawing.Point(18, 82)
        Me.LblProblem.Name = "LblProblem"
        Me.LblProblem.Size = New System.Drawing.Size(54, 17)
        Me.LblProblem.TabIndex = 9
        Me.LblProblem.Text = "Problem"
        '
        'TxtIssueDate
        '
        Me.TxtIssueDate.BackColor = System.Drawing.SystemColors.Control
        Me.TxtIssueDate.Enabled = False
        Me.TxtIssueDate.Location = New System.Drawing.Point(18, 46)
        Me.TxtIssueDate.Name = "TxtIssueDate"
        Me.TxtIssueDate.ReadOnly = True
        Me.TxtIssueDate.Size = New System.Drawing.Size(264, 24)
        Me.TxtIssueDate.TabIndex = 8
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("Source Sans Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(13, 456)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(523, 42)
        Me.BtnSubmit.TabIndex = 16
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbSupportList)
        Me.GroupBox1.Controls.Add(Me.LblSupportList)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 99)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CmbCategory)
        Me.GroupBox4.Controls.Add(Me.LblCategory)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 356)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(222, 94)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'CmbCategory
        '
        Me.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCategory.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Location = New System.Drawing.Point(15, 46)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(189, 28)
        Me.CmbCategory.TabIndex = 4
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Location = New System.Drawing.Point(15, 26)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(57, 17)
        Me.LblCategory.TabIndex = 3
        Me.LblCategory.Text = "Category"
        '
        'CloseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 531)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Source Sans Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CloseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Close Form"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LblUsername As ToolStripLabel
    Friend WithEvents LblType As ToolStripLabel
    Friend WithEvents LblCheckerName As Label
    Friend WithEvents TxtCheckerRegistration As TextBox
    Friend WithEvents LblCheckerRegistration As Label
    Friend WithEvents TxtDepartment As TextBox
    Friend WithEvents LblDepartment As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtLine As TextBox
    Friend WithEvents LblLine As Label
    Friend WithEvents TxtCheckerName As TextBox
    Friend WithEvents CmbSupportList As ComboBox
    Friend WithEvents LblSupportList As Label
    Friend WithEvents LblIssueDate As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtProblem As RichTextBox
    Friend WithEvents LblProblem As Label
    Friend WithEvents TxtIssueDate As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CmbCategory As ComboBox
    Friend WithEvents LblCategory As Label
    Friend WithEvents txtAction As RichTextBox
    Friend WithEvents LblAction As Label
End Class
