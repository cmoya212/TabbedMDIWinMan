<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFormCustomPaint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFormCustomPaint))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMenuItem = New System.Windows.Forms.MenuItem
        Me.FileExitMenuItem = New System.Windows.Forms.MenuItem
        Me.WindowManagerPanel1 = New MDIWindowManager.WindowManagerPanel
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileMenuItem})
        '
        'FileMenuItem
        '
        Me.FileMenuItem.Index = 0
        Me.FileMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileExitMenuItem})
        resources.ApplyResources(Me.FileMenuItem, "FileMenuItem")
        '
        'FileExitMenuItem
        '
        Me.FileExitMenuItem.Index = 0
        resources.ApplyResources(Me.FileExitMenuItem, "FileExitMenuItem")
        '
        'WindowManagerPanel1
        '
        Me.WindowManagerPanel1.AllowUserVerticalRepositioning = False
        Me.WindowManagerPanel1.AutoDetectMdiChildWindows = True
        Me.WindowManagerPanel1.AutoHide = False
        Me.WindowManagerPanel1.ButtonRenderMode = MDIWindowManager.ButtonRenderMode.Standard
        Me.WindowManagerPanel1.DisableCloseAction = False
        Me.WindowManagerPanel1.DisableHTileAction = False
        Me.WindowManagerPanel1.DisablePopoutAction = False
        Me.WindowManagerPanel1.DisableTileAction = False
        Me.WindowManagerPanel1.EnableTabPaintEvent = True
        resources.ApplyResources(Me.WindowManagerPanel1, "WindowManagerPanel1")
        Me.WindowManagerPanel1.MinMode = False
        Me.WindowManagerPanel1.Name = "WindowManagerPanel1"
        Me.WindowManagerPanel1.Orientation = MDIWindowManager.WindowManagerOrientation.Top
        Me.WindowManagerPanel1.ShowCloseButton = True
        Me.WindowManagerPanel1.ShowIcons = True
        Me.WindowManagerPanel1.ShowLayoutButtons = True
        Me.WindowManagerPanel1.ShowTitle = False
        Me.WindowManagerPanel1.Style = MDIWindowManager.TabStyle.AngledHiliteTabs
        Me.WindowManagerPanel1.TabRenderMode = MDIWindowManager.TabsProvider.Standard
        Me.WindowManagerPanel1.TitleBackColor = System.Drawing.SystemColors.ControlDark
        Me.WindowManagerPanel1.TitleForeColor = System.Drawing.SystemColors.ControlLightLight
        '
        'MainFormCustomPaint
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WindowManagerPanel1)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MainFormCustomPaint"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WindowManagerPanel1 As MDIWindowManager.WindowManagerPanel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents FileMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents FileExitMenuItem As System.Windows.Forms.MenuItem
End Class
