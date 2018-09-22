<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.reload = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me._next = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.Button()
        Me.search_fg = New System.Windows.Forms.TextBox()
        Me.tabcontrol = New System.Windows.Forms.TabControl()
        Me.search_bg = New System.Windows.Forms.PictureBox()
        Me.add = New System.Windows.Forms.Button()
        Me.remove = New System.Windows.Forms.Button()
        CType(Me.search_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reload
        '
        Me.reload.Image = CType(resources.GetObject("reload.Image"), System.Drawing.Image)
        Me.reload.Location = New System.Drawing.Point(88, 12)
        Me.reload.Name = "reload"
        Me.reload.Size = New System.Drawing.Size(32, 32)
        Me.reload.TabIndex = 4
        Me.reload.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.Location = New System.Drawing.Point(12, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(32, 32)
        Me.back.TabIndex = 3
        Me.back.UseVisualStyleBackColor = True
        '
        '_next
        '
        Me._next.Image = CType(resources.GetObject("_next.Image"), System.Drawing.Image)
        Me._next.Location = New System.Drawing.Point(50, 12)
        Me._next.Name = "_next"
        Me._next.Size = New System.Drawing.Size(32, 32)
        Me._next.TabIndex = 2
        Me._next.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settings.Image = CType(resources.GetObject("settings.Image"), System.Drawing.Image)
        Me.settings.Location = New System.Drawing.Point(756, 12)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(32, 32)
        Me.settings.TabIndex = 1
        Me.settings.UseVisualStyleBackColor = True
        '
        'search_fg
        '
        Me.search_fg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_fg.Location = New System.Drawing.Point(126, 19)
        Me.search_fg.Name = "search_fg"
        Me.search_fg.Size = New System.Drawing.Size(548, 20)
        Me.search_fg.TabIndex = 5
        '
        'tabcontrol
        '
        Me.tabcontrol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrol.Location = New System.Drawing.Point(12, 50)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(776, 388)
        Me.tabcontrol.TabIndex = 6
        '
        'search_bg
        '
        Me.search_bg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_bg.BackColor = System.Drawing.Color.White
        Me.search_bg.Location = New System.Drawing.Point(126, 12)
        Me.search_bg.Name = "search_bg"
        Me.search_bg.Size = New System.Drawing.Size(548, 32)
        Me.search_bg.TabIndex = 7
        Me.search_bg.TabStop = False
        '
        'add
        '
        Me.add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.add.Image = Global.LisBrowser_Gecko.My.Resources.Resources.add
        Me.add.Location = New System.Drawing.Point(680, 12)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(32, 32)
        Me.add.TabIndex = 8
        Me.add.UseVisualStyleBackColor = True
        '
        'remove
        '
        Me.remove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.remove.Image = Global.LisBrowser_Gecko.My.Resources.Resources.remove
        Me.remove.Location = New System.Drawing.Point(718, 12)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(32, 32)
        Me.remove.TabIndex = 9
        Me.remove.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.remove)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.tabcontrol)
        Me.Controls.Add(Me.search_fg)
        Me.Controls.Add(Me.reload)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me._next)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.search_bg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "LisBrowser Gecko"
        CType(Me.search_bg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents settings As Button
    Friend WithEvents _next As Button
    Friend WithEvents back As Button
    Friend WithEvents reload As Button
    Friend WithEvents search_fg As TextBox
    Friend WithEvents tabcontrol As TabControl
    Friend WithEvents search_bg As PictureBox
    Friend WithEvents add As Button
    Friend WithEvents remove As Button
End Class
