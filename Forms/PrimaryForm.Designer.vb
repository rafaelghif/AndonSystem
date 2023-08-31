<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrimaryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrimaryForm))
        Me.WatchLogTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BtnIssue = New System.Windows.Forms.Button()
        Me.BtnAccept = New System.Windows.Forms.Button()
        Me.BtnArrive = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WatchLogTimer
        '
        '
        'BtnIssue
        '
        Me.BtnIssue.Font = New System.Drawing.Font("Source Sans Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIssue.Location = New System.Drawing.Point(12, 12)
        Me.BtnIssue.Name = "BtnIssue"
        Me.BtnIssue.Size = New System.Drawing.Size(237, 40)
        Me.BtnIssue.TabIndex = 0
        Me.BtnIssue.Text = "Issue Support"
        Me.BtnIssue.UseVisualStyleBackColor = True
        '
        'BtnAccept
        '
        Me.BtnAccept.Font = New System.Drawing.Font("Source Sans Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccept.Location = New System.Drawing.Point(12, 58)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(237, 40)
        Me.BtnAccept.TabIndex = 1
        Me.BtnAccept.Text = "Accept Support"
        Me.BtnAccept.UseVisualStyleBackColor = True
        '
        'BtnArrive
        '
        Me.BtnArrive.Font = New System.Drawing.Font("Source Sans Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArrive.Location = New System.Drawing.Point(12, 104)
        Me.BtnArrive.Name = "BtnArrive"
        Me.BtnArrive.Size = New System.Drawing.Size(237, 40)
        Me.BtnArrive.TabIndex = 2
        Me.BtnArrive.Text = "Arrive Support"
        Me.BtnArrive.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Source Sans Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(12, 150)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(237, 40)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "Close Support"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Font = New System.Drawing.Font("Source Sans Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplay.Location = New System.Drawing.Point(12, 196)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(237, 40)
        Me.BtnDisplay.TabIndex = 4
        Me.BtnDisplay.Text = "Andon Display"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'PrimaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 245)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnArrive)
        Me.Controls.Add(Me.BtnAccept)
        Me.Controls.Add(Me.BtnIssue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrimaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Andon System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WatchLogTimer As Timer
    Friend WithEvents BtnIssue As Button
    Friend WithEvents BtnAccept As Button
    Friend WithEvents BtnArrive As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDisplay As Button
End Class
