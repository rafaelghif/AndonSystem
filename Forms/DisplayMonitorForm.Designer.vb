<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayMonitorForm
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
        Me.components = New System.ComponentModel.Container()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblSubTitle = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblType = New System.Windows.Forms.Label()
        Me.LblPic = New System.Windows.Forms.Label()
        Me.LblIssueDate = New System.Windows.Forms.Label()
        Me.LblProblem = New System.Windows.Forms.Label()
        Me.LblCheckerName = New System.Windows.Forms.Label()
        Me.LblLine = New System.Windows.Forms.Label()
        Me.RefreshAndonTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(307, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(176, 34)
        Me.LblTitle.TabIndex = 2
        Me.LblTitle.Text = "Andon System"
        '
        'LblSubTitle
        '
        Me.LblSubTitle.AutoSize = True
        Me.LblSubTitle.Font = New System.Drawing.Font("Source Sans Pro", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle.ForeColor = System.Drawing.Color.White
        Me.LblSubTitle.Location = New System.Drawing.Point(291, 43)
        Me.LblSubTitle.Name = "LblSubTitle"
        Me.LblSubTitle.Size = New System.Drawing.Size(213, 19)
        Me.LblSubTitle.TabIndex = 3
        Me.LblSubTitle.Text = "Yokogawa Manufacturing Batam"
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Source Sans Pro", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(704, 28)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 34)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Location = New System.Drawing.Point(13, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 556)
        Me.Panel1.TabIndex = 5
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblType.ForeColor = System.Drawing.Color.White
        Me.LblType.Location = New System.Drawing.Point(1012, 95)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(45, 20)
        Me.LblType.TabIndex = 17
        Me.LblType.Text = "Type"
        '
        'LblPic
        '
        Me.LblPic.AutoSize = True
        Me.LblPic.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPic.ForeColor = System.Drawing.Color.White
        Me.LblPic.Location = New System.Drawing.Point(865, 95)
        Me.LblPic.Name = "LblPic"
        Me.LblPic.Size = New System.Drawing.Size(32, 20)
        Me.LblPic.TabIndex = 16
        Me.LblPic.Text = "Pic"
        '
        'LblIssueDate
        '
        Me.LblIssueDate.AutoSize = True
        Me.LblIssueDate.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIssueDate.ForeColor = System.Drawing.Color.White
        Me.LblIssueDate.Location = New System.Drawing.Point(667, 95)
        Me.LblIssueDate.Name = "LblIssueDate"
        Me.LblIssueDate.Size = New System.Drawing.Size(49, 20)
        Me.LblIssueDate.TabIndex = 15
        Me.LblIssueDate.Text = "Issue"
        '
        'LblProblem
        '
        Me.LblProblem.AutoSize = True
        Me.LblProblem.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProblem.ForeColor = System.Drawing.Color.White
        Me.LblProblem.Location = New System.Drawing.Point(485, 95)
        Me.LblProblem.Name = "LblProblem"
        Me.LblProblem.Size = New System.Drawing.Size(74, 20)
        Me.LblProblem.TabIndex = 14
        Me.LblProblem.Text = "Problem"
        '
        'LblCheckerName
        '
        Me.LblCheckerName.AutoSize = True
        Me.LblCheckerName.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCheckerName.ForeColor = System.Drawing.Color.White
        Me.LblCheckerName.Location = New System.Drawing.Point(238, 95)
        Me.LblCheckerName.Name = "LblCheckerName"
        Me.LblCheckerName.Size = New System.Drawing.Size(118, 20)
        Me.LblCheckerName.TabIndex = 13
        Me.LblCheckerName.Text = "Checker Name"
        '
        'LblLine
        '
        Me.LblLine.AutoSize = True
        Me.LblLine.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLine.ForeColor = System.Drawing.Color.White
        Me.LblLine.Location = New System.Drawing.Point(79, 95)
        Me.LblLine.Name = "LblLine"
        Me.LblLine.Size = New System.Drawing.Size(42, 20)
        Me.LblLine.TabIndex = 12
        Me.LblLine.Text = "Line"
        '
        'RefreshAndonTimer
        '
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.ForeColor = System.Drawing.Color.White
        Me.LblStatus.Location = New System.Drawing.Point(753, 95)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(58, 20)
        Me.LblStatus.TabIndex = 18
        Me.LblStatus.Text = "Status"
        '
        'DisplayForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1125, 686)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.LblType)
        Me.Controls.Add(Me.LblPic)
        Me.Controls.Add(Me.LblIssueDate)
        Me.Controls.Add(Me.LblProblem)
        Me.Controls.Add(Me.LblCheckerName)
        Me.Controls.Add(Me.LblLine)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LblSubTitle)
        Me.Controls.Add(Me.LblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DisplayForm2"
        Me.Text = "DisplayForm2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblSubTitle As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblType As Label
    Friend WithEvents LblPic As Label
    Friend WithEvents LblIssueDate As Label
    Friend WithEvents LblProblem As Label
    Friend WithEvents LblCheckerName As Label
    Friend WithEvents LblLine As Label
    Friend WithEvents RefreshAndonTimer As Timer
    Friend WithEvents LblStatus As Label
End Class
