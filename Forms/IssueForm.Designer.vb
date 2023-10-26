<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IssueForm))
        Me.LblCheckerRegistration = New System.Windows.Forms.Label()
        Me.TxtCheckerRegistration = New System.Windows.Forms.TextBox()
        Me.TxtCheckerName = New System.Windows.Forms.TextBox()
        Me.LblCheckerName = New System.Windows.Forms.Label()
        Me.LblProblem = New System.Windows.Forms.Label()
        Me.BtnEngSupport = New System.Windows.Forms.Button()
        Me.BtnProductionSupport = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.CmbProblem = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LblCheckerRegistration
        '
        Me.LblCheckerRegistration.AutoSize = True
        Me.LblCheckerRegistration.Font = New System.Drawing.Font("Source Sans Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCheckerRegistration.Location = New System.Drawing.Point(12, 9)
        Me.LblCheckerRegistration.Name = "LblCheckerRegistration"
        Me.LblCheckerRegistration.Size = New System.Drawing.Size(97, 17)
        Me.LblCheckerRegistration.TabIndex = 0
        Me.LblCheckerRegistration.Text = "Checker Register"
        '
        'TxtCheckerRegistration
        '
        Me.TxtCheckerRegistration.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCheckerRegistration.Enabled = False
        Me.TxtCheckerRegistration.Font = New System.Drawing.Font("Source Sans Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCheckerRegistration.Location = New System.Drawing.Point(12, 29)
        Me.TxtCheckerRegistration.Name = "TxtCheckerRegistration"
        Me.TxtCheckerRegistration.ReadOnly = True
        Me.TxtCheckerRegistration.Size = New System.Drawing.Size(273, 24)
        Me.TxtCheckerRegistration.TabIndex = 99
        Me.TxtCheckerRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCheckerName
        '
        Me.TxtCheckerName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCheckerName.Enabled = False
        Me.TxtCheckerName.Font = New System.Drawing.Font("Source Sans Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCheckerName.Location = New System.Drawing.Point(12, 82)
        Me.TxtCheckerName.Name = "TxtCheckerName"
        Me.TxtCheckerName.ReadOnly = True
        Me.TxtCheckerName.Size = New System.Drawing.Size(273, 24)
        Me.TxtCheckerName.TabIndex = 99
        Me.TxtCheckerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCheckerName
        '
        Me.LblCheckerName.AutoSize = True
        Me.LblCheckerName.Font = New System.Drawing.Font("Source Sans Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCheckerName.Location = New System.Drawing.Point(12, 62)
        Me.LblCheckerName.Name = "LblCheckerName"
        Me.LblCheckerName.Size = New System.Drawing.Size(97, 17)
        Me.LblCheckerName.TabIndex = 2
        Me.LblCheckerName.Text = "Checker Register"
        '
        'LblProblem
        '
        Me.LblProblem.AutoSize = True
        Me.LblProblem.Font = New System.Drawing.Font("Source Sans Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProblem.Location = New System.Drawing.Point(12, 120)
        Me.LblProblem.Name = "LblProblem"
        Me.LblProblem.Size = New System.Drawing.Size(54, 17)
        Me.LblProblem.TabIndex = 4
        Me.LblProblem.Text = "Problem"
        '
        'BtnEngSupport
        '
        Me.BtnEngSupport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEngSupport.Font = New System.Drawing.Font("Source Sans Pro", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEngSupport.Location = New System.Drawing.Point(132, 212)
        Me.BtnEngSupport.Name = "BtnEngSupport"
        Me.BtnEngSupport.Size = New System.Drawing.Size(153, 68)
        Me.BtnEngSupport.TabIndex = 2
        Me.BtnEngSupport.Text = "Engineering Support"
        Me.BtnEngSupport.UseVisualStyleBackColor = True
        '
        'BtnProductionSupport
        '
        Me.BtnProductionSupport.Font = New System.Drawing.Font("Source Sans Pro", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductionSupport.Location = New System.Drawing.Point(132, 171)
        Me.BtnProductionSupport.Name = "BtnProductionSupport"
        Me.BtnProductionSupport.Size = New System.Drawing.Size(153, 35)
        Me.BtnProductionSupport.TabIndex = 1
        Me.BtnProductionSupport.Text = "Production Support"
        Me.BtnProductionSupport.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Source Sans Pro", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(12, 171)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(111, 113)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "END"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'CmbProblem
        '
        Me.CmbProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProblem.Font = New System.Drawing.Font("Source Sans Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbProblem.FormattingEnabled = True
        Me.CmbProblem.Location = New System.Drawing.Point(15, 140)
        Me.CmbProblem.Name = "CmbProblem"
        Me.CmbProblem.Size = New System.Drawing.Size(270, 25)
        Me.CmbProblem.TabIndex = 100
        '
        'IssueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 292)
        Me.Controls.Add(Me.CmbProblem)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnProductionSupport)
        Me.Controls.Add(Me.BtnEngSupport)
        Me.Controls.Add(Me.LblProblem)
        Me.Controls.Add(Me.TxtCheckerName)
        Me.Controls.Add(Me.LblCheckerName)
        Me.Controls.Add(Me.TxtCheckerRegistration)
        Me.Controls.Add(Me.LblCheckerRegistration)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IssueForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issue Support"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCheckerRegistration As Label
    Friend WithEvents TxtCheckerRegistration As TextBox
    Friend WithEvents TxtCheckerName As TextBox
    Friend WithEvents LblCheckerName As Label
    Friend WithEvents LblProblem As Label
    Friend WithEvents BtnEngSupport As Button
    Friend WithEvents BtnProductionSupport As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents CmbProblem As ComboBox
End Class
