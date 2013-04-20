<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.FraImage = New System.Windows.Forms.GroupBox()
        Me.CmdFill = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdCopyToClipBoard = New System.Windows.Forms.Button()
        Me.TxtHEX = New System.Windows.Forms.TextBox()
        Me.FraPreview = New System.Windows.Forms.GroupBox()
        Me.LblSecret = New System.Windows.Forms.Label()
        Me.TmrSecret = New System.Windows.Forms.Timer(Me.components)
        Me.StsBottom = New System.Windows.Forms.StatusStrip()
        Me.StsLblNameLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StsLblName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyHEXToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearDisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FillDisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.DlgSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.FraImage.SuspendLayout()
        Me.StsBottom.SuspendLayout()
        Me.MnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'FraImage
        '
        Me.FraImage.Controls.Add(Me.CmdFill)
        Me.FraImage.Controls.Add(Me.CmdClear)
        Me.FraImage.Location = New System.Drawing.Point(14, 63)
        Me.FraImage.Name = "FraImage"
        Me.FraImage.Size = New System.Drawing.Size(240, 249)
        Me.FraImage.TabIndex = 4
        Me.FraImage.TabStop = False
        Me.FraImage.Text = "Image"
        '
        'CmdFill
        '
        Me.CmdFill.Location = New System.Drawing.Point(0, 226)
        Me.CmdFill.Name = "CmdFill"
        Me.CmdFill.Size = New System.Drawing.Size(122, 23)
        Me.CmdFill.TabIndex = 7
        Me.CmdFill.Text = "&Fill"
        Me.CmdFill.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(121, 226)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(120, 23)
        Me.CmdClear.TabIndex = 6
        Me.CmdClear.Text = "&Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdCopyToClipBoard
        '
        Me.CmdCopyToClipBoard.Location = New System.Drawing.Point(260, 34)
        Me.CmdCopyToClipBoard.Name = "CmdCopyToClipBoard"
        Me.CmdCopyToClipBoard.Size = New System.Drawing.Size(122, 23)
        Me.CmdCopyToClipBoard.TabIndex = 5
        Me.CmdCopyToClipBoard.Text = "Copy to Clipboard"
        Me.CmdCopyToClipBoard.UseVisualStyleBackColor = True
        '
        'TxtHEX
        '
        Me.TxtHEX.Location = New System.Drawing.Point(14, 37)
        Me.TxtHEX.Name = "TxtHEX"
        Me.TxtHEX.Size = New System.Drawing.Size(240, 20)
        Me.TxtHEX.TabIndex = 6
        Me.TxtHEX.Text = "0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00"
        Me.TxtHEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FraPreview
        '
        Me.FraPreview.Location = New System.Drawing.Point(260, 64)
        Me.FraPreview.Name = "FraPreview"
        Me.FraPreview.Size = New System.Drawing.Size(122, 100)
        Me.FraPreview.TabIndex = 5
        Me.FraPreview.TabStop = False
        Me.FraPreview.Text = "Preview"
        '
        'LblSecret
        '
        Me.LblSecret.ForeColor = System.Drawing.SystemColors.Control
        Me.LblSecret.Location = New System.Drawing.Point(260, 167)
        Me.LblSecret.Name = "LblSecret"
        Me.LblSecret.Size = New System.Drawing.Size(122, 145)
        Me.LblSecret.TabIndex = 7
        Me.LblSecret.Text = "0"
        '
        'TmrSecret
        '
        Me.TmrSecret.Interval = 5000
        '
        'StsBottom
        '
        Me.StsBottom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StsLblNameLabel, Me.StsLblName})
        Me.StsBottom.Location = New System.Drawing.Point(0, 320)
        Me.StsBottom.Name = "StsBottom"
        Me.StsBottom.Size = New System.Drawing.Size(394, 22)
        Me.StsBottom.TabIndex = 8
        Me.StsBottom.Text = "StatusStrip1"
        '
        'StsLblNameLabel
        '
        Me.StsLblNameLabel.Name = "StsLblNameLabel"
        Me.StsLblNameLabel.Size = New System.Drawing.Size(66, 17)
        Me.StsLblNameLabel.Text = "File Name: "
        '
        'StsLblName
        '
        Me.StsLblName.Name = "StsLblName"
        Me.StsLblName.Size = New System.Drawing.Size(82, 17)
        Me.StsLblName.Text = "File Not Saved"
        '
        'MnuMain
        '
        Me.MnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MnuMain.Location = New System.Drawing.Point(0, 0)
        Me.MnuMain.Name = "MnuMain"
        Me.MnuMain.Size = New System.Drawing.Size(394, 24)
        Me.MnuMain.TabIndex = 9
        Me.MnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.LoadToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.LoadToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyHEXToClipboardToolStripMenuItem, Me.ClearDisplayToolStripMenuItem, Me.FillDisplayToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CopyHEXToClipboardToolStripMenuItem
        '
        Me.CopyHEXToClipboardToolStripMenuItem.Name = "CopyHEXToClipboardToolStripMenuItem"
        Me.CopyHEXToClipboardToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyHEXToClipboardToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CopyHEXToClipboardToolStripMenuItem.Text = "Copy HEX to Clipboard"
        '
        'ClearDisplayToolStripMenuItem
        '
        Me.ClearDisplayToolStripMenuItem.Name = "ClearDisplayToolStripMenuItem"
        Me.ClearDisplayToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ClearDisplayToolStripMenuItem.Text = "Clear Display"
        '
        'FillDisplayToolStripMenuItem
        '
        Me.FillDisplayToolStripMenuItem.Name = "FillDisplayToolStripMenuItem"
        Me.FillDisplayToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.FillDisplayToolStripMenuItem.Text = "Fill Display"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AboutToolStripMenuItem.Text = "About .."
        '
        'DlgOpenFile
        '
        Me.DlgOpenFile.FileName = "CustomChar1"
        Me.DlgOpenFile.Filter = """Custom Character Generator|*.cgg|All files|*.*"""
        Me.DlgOpenFile.Title = "Open Custom Character File"
        '
        'DlgSaveFile
        '
        Me.DlgSaveFile.DefaultExt = "*.cgg"
        Me.DlgSaveFile.FileName = "CustomChar1"
        Me.DlgSaveFile.Filter = """Custom Character Generator|*.cgg|All files|*.*"""
        Me.DlgSaveFile.Title = "Save Custom Character File"
        Me.DlgSaveFile.ValidateNames = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 342)
        Me.Controls.Add(Me.StsBottom)
        Me.Controls.Add(Me.MnuMain)
        Me.Controls.Add(Me.LblSecret)
        Me.Controls.Add(Me.FraPreview)
        Me.Controls.Add(Me.TxtHEX)
        Me.Controls.Add(Me.CmdCopyToClipBoard)
        Me.Controls.Add(Me.FraImage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MnuMain
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(410, 380)
        Me.MinimumSize = New System.Drawing.Size(410, 380)
        Me.Name = "FrmMain"
        Me.Text = "HD44780 Character Generator"
        Me.FraImage.ResumeLayout(False)
        Me.StsBottom.ResumeLayout(False)
        Me.StsBottom.PerformLayout()
        Me.MnuMain.ResumeLayout(False)
        Me.MnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FraImage As System.Windows.Forms.GroupBox
    Friend WithEvents CmdCopyToClipBoard As System.Windows.Forms.Button
    Friend WithEvents TxtHEX As System.Windows.Forms.TextBox
    Friend WithEvents FraPreview As System.Windows.Forms.GroupBox
    Friend WithEvents CmdFill As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents LblSecret As System.Windows.Forms.Label
    Friend WithEvents TmrSecret As System.Windows.Forms.Timer
    Friend WithEvents StsBottom As System.Windows.Forms.StatusStrip
    Friend WithEvents StsLblNameLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StsLblName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DlgSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyHEXToClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearDisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FillDisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
