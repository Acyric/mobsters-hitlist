<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnStart = New System.Windows.Forms.Button
        Me.tRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnAttack = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.DimGray
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(528, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 22)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'tRefresh
        '
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.DimGray
        Me.btnRefresh.Location = New System.Drawing.Point(419, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(103, 22)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Calibrate Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnAttack
        '
        Me.btnAttack.BackColor = System.Drawing.Color.DimGray
        Me.btnAttack.Location = New System.Drawing.Point(419, 40)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(103, 22)
        Me.btnAttack.TabIndex = 2
        Me.btnAttack.Text = "Calibrate Attack"
        Me.btnAttack.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Location = New System.Drawing.Point(528, 40)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 22)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(615, 75)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobsters Hit-List"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents tRefresh As System.Windows.Forms.Timer
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAttack As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
