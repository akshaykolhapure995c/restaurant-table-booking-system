<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WaiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FoodItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.ViewToolStripMenuItem, Me.OtherToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(594, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WaiterToolStripMenuItem, Me.FoodItemToolStripMenuItem, Me.TablesToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.ADDToolStripMenuItem.Text = "Add"
        '
        'WaiterToolStripMenuItem
        '
        Me.WaiterToolStripMenuItem.Name = "WaiterToolStripMenuItem"
        Me.WaiterToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.WaiterToolStripMenuItem.Text = "Waiter"
        '
        'FoodItemToolStripMenuItem
        '
        Me.FoodItemToolStripMenuItem.Name = "FoodItemToolStripMenuItem"
        Me.FoodItemToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.FoodItemToolStripMenuItem.Text = "Food item"
        '
        'TablesToolStripMenuItem
        '
        Me.TablesToolStripMenuItem.Name = "TablesToolStripMenuItem"
        Me.TablesToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.TablesToolStripMenuItem.Text = "Tables"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.CloseToolStripMenuItem.Text = "close"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'OtherToolStripMenuItem
        '
        Me.OtherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackUpToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutDeveloperToolStripMenuItem})
        Me.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        Me.OtherToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.OtherToolStripMenuItem.Text = "Other"
        '
        'BackUpToolStripMenuItem
        '
        Me.BackUpToolStripMenuItem.Name = "BackUpToolStripMenuItem"
        Me.BackUpToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BackUpToolStripMenuItem.Text = "Back up"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change password"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutDeveloperToolStripMenuItem
        '
        Me.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem"
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AboutDeveloperToolStripMenuItem.Text = "About developer"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 373)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.Text = "Hotel Table Booking System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ADDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WaiterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoodItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutDeveloperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
