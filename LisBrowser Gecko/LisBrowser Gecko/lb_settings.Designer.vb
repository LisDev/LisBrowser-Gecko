<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lb_settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lb_settings))
        Me.icons_von = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.von = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.copyright = New System.Windows.Forms.Label()
        Me.homepage_tb = New System.Windows.Forms.TextBox()
        Me.homepage = New System.Windows.Forms.Label()
        Me.black = New System.Windows.Forms.PictureBox()
        Me.color_fg = New System.Windows.Forms.Label()
        Me.blue = New System.Windows.Forms.PictureBox()
        Me.green = New System.Windows.Forms.PictureBox()
        Me.red = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.white_bg = New System.Windows.Forms.PictureBox()
        Me.color_bg = New System.Windows.Forms.Label()
        Me.black_bg = New System.Windows.Forms.PictureBox()
        Me.settings_label = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.Label()
        Me.search_tb = New System.Windows.Forms.TextBox()
        Me.version = New System.Windows.Forms.Label()
        Me.Verlauf = New System.Windows.Forms.ListBox()
        Me.history = New System.Windows.Forms.Label()
        Me.Verlauf_2 = New System.Windows.Forms.ListBox()
        Me.clear = New System.Windows.Forms.Button()
        CType(Me.black, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.green, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.white_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'icons_von
        '
        Me.icons_von.AutoSize = True
        Me.icons_von.Location = New System.Drawing.Point(14, 465)
        Me.icons_von.Name = "icons_von"
        Me.icons_von.Size = New System.Drawing.Size(54, 13)
        Me.icons_von.TabIndex = 0
        Me.icons_von.Text = "Icons von"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkArea = New System.Windows.Forms.LinkArea(0, 7)
        Me.LinkLabel1.Location = New System.Drawing.Point(67, 465)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(45, 17)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Freepik,"
        Me.LinkLabel1.UseCompatibleTextRendering = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkArea = New System.Windows.Forms.LinkArea(0, 14)
        Me.LinkLabel2.Location = New System.Drawing.Point(111, 465)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(86, 17)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Gregor Cresnar,"
        Me.LinkLabel2.UseCompatibleTextRendering = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkArea = New System.Windows.Forms.LinkArea(0, 10)
        Me.LinkLabel3.Location = New System.Drawing.Point(194, 465)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(69, 17)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Smashicons "
        Me.LinkLabel3.UseCompatibleTextRendering = True
        '
        'von
        '
        Me.von.AutoSize = True
        Me.von.Location = New System.Drawing.Point(259, 465)
        Me.von.Name = "von"
        Me.von.Size = New System.Drawing.Size(25, 13)
        Me.von.TabIndex = 4
        Me.von.Text = "von"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.LinkArea = New System.Windows.Forms.LinkArea(0, 16)
        Me.LinkLabel4.Location = New System.Drawing.Point(286, 465)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(95, 17)
        Me.LinkLabel4.TabIndex = 5
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "www.flaticon.com "
        Me.LinkLabel4.UseCompatibleTextRendering = True
        '
        'copyright
        '
        Me.copyright.AutoSize = True
        Me.copyright.Location = New System.Drawing.Point(14, 478)
        Me.copyright.Name = "copyright"
        Me.copyright.Size = New System.Drawing.Size(125, 13)
        Me.copyright.TabIndex = 6
        Me.copyright.Text = "Copyright nicht ermittelt..."
        '
        'homepage_tb
        '
        Me.homepage_tb.Location = New System.Drawing.Point(82, 335)
        Me.homepage_tb.Name = "homepage_tb"
        Me.homepage_tb.Size = New System.Drawing.Size(419, 20)
        Me.homepage_tb.TabIndex = 7
        '
        'homepage
        '
        Me.homepage.AutoSize = True
        Me.homepage.Location = New System.Drawing.Point(14, 338)
        Me.homepage.Name = "homepage"
        Me.homepage.Size = New System.Drawing.Size(62, 13)
        Me.homepage.TabIndex = 8
        Me.homepage.Text = "Homepage:"
        '
        'black
        '
        Me.black.BackColor = System.Drawing.SystemColors.Control
        Me.black.Image = Global.LisBrowser_Gecko.My.Resources.Resources.black
        Me.black.Location = New System.Drawing.Point(82, 386)
        Me.black.Name = "black"
        Me.black.Size = New System.Drawing.Size(24, 24)
        Me.black.TabIndex = 9
        Me.black.TabStop = False
        '
        'color_fg
        '
        Me.color_fg.AutoSize = True
        Me.color_fg.Location = New System.Drawing.Point(14, 414)
        Me.color_fg.Name = "color_fg"
        Me.color_fg.Size = New System.Drawing.Size(37, 13)
        Me.color_fg.TabIndex = 10
        Me.color_fg.Text = "Farbe:"
        '
        'blue
        '
        Me.blue.Image = Global.LisBrowser_Gecko.My.Resources.Resources.blue
        Me.blue.Location = New System.Drawing.Point(112, 386)
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(24, 24)
        Me.blue.TabIndex = 11
        Me.blue.TabStop = False
        '
        'green
        '
        Me.green.Image = Global.LisBrowser_Gecko.My.Resources.Resources.green
        Me.green.Location = New System.Drawing.Point(142, 386)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(24, 24)
        Me.green.TabIndex = 12
        Me.green.TabStop = False
        '
        'red
        '
        Me.red.Image = Global.LisBrowser_Gecko.My.Resources.Resources.red
        Me.red.Location = New System.Drawing.Point(172, 386)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(24, 24)
        Me.red.TabIndex = 13
        Me.red.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LisBrowser_Gecko.My.Resources.Resources.yellow
        Me.PictureBox1.Location = New System.Drawing.Point(202, 386)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'white_bg
        '
        Me.white_bg.BackColor = System.Drawing.SystemColors.Control
        Me.white_bg.Image = Global.LisBrowser_Gecko.My.Resources.Resources.bg_black
        Me.white_bg.Location = New System.Drawing.Point(82, 416)
        Me.white_bg.Name = "white_bg"
        Me.white_bg.Size = New System.Drawing.Size(24, 24)
        Me.white_bg.TabIndex = 15
        Me.white_bg.TabStop = False
        '
        'color_bg
        '
        Me.color_bg.AutoSize = True
        Me.color_bg.Location = New System.Drawing.Point(14, 384)
        Me.color_bg.Name = "color_bg"
        Me.color_bg.Size = New System.Drawing.Size(65, 26)
        Me.color_bg.TabIndex = 21
        Me.color_bg.Text = "Hintergrund-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "farbe:"
        '
        'black_bg
        '
        Me.black_bg.BackColor = System.Drawing.Color.Black
        Me.black_bg.Image = Global.LisBrowser_Gecko.My.Resources.Resources.bg_white
        Me.black_bg.Location = New System.Drawing.Point(112, 416)
        Me.black_bg.Name = "black_bg"
        Me.black_bg.Size = New System.Drawing.Size(24, 24)
        Me.black_bg.TabIndex = 22
        Me.black_bg.TabStop = False
        '
        'settings_label
        '
        Me.settings_label.AutoSize = True
        Me.settings_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_label.Location = New System.Drawing.Point(12, 307)
        Me.settings_label.Name = "settings_label"
        Me.settings_label.Size = New System.Drawing.Size(135, 25)
        Me.settings_label.TabIndex = 23
        Me.settings_label.Text = "Einstellungen:"
        '
        'search
        '
        Me.search.AutoSize = True
        Me.search.Location = New System.Drawing.Point(14, 364)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(41, 13)
        Me.search.TabIndex = 25
        Me.search.Text = "Suche:"
        '
        'search_tb
        '
        Me.search_tb.Location = New System.Drawing.Point(82, 361)
        Me.search_tb.Name = "search_tb"
        Me.search_tb.Size = New System.Drawing.Size(420, 20)
        Me.search_tb.TabIndex = 24
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.Location = New System.Drawing.Point(12, 452)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(116, 13)
        Me.version.TabIndex = 26
        Me.version.Text = "Version nicht ermittelt..."
        '
        'Verlauf
        '
        Me.Verlauf.FormattingEnabled = True
        Me.Verlauf.Location = New System.Drawing.Point(12, 37)
        Me.Verlauf.Name = "Verlauf"
        Me.Verlauf.Size = New System.Drawing.Size(355, 238)
        Me.Verlauf.TabIndex = 27
        '
        'history
        '
        Me.history.AutoSize = True
        Me.history.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.history.Location = New System.Drawing.Point(7, 9)
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(80, 25)
        Me.history.TabIndex = 28
        Me.history.Text = "Verlauf:"
        '
        'Verlauf_2
        '
        Me.Verlauf_2.FormattingEnabled = True
        Me.Verlauf_2.Location = New System.Drawing.Point(373, 37)
        Me.Verlauf_2.Name = "Verlauf_2"
        Me.Verlauf_2.Size = New System.Drawing.Size(128, 238)
        Me.Verlauf_2.TabIndex = 29
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(12, 281)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(490, 23)
        Me.clear.TabIndex = 30
        Me.clear.Text = "Verlauf leeren"
        Me.clear.UseVisualStyleBackColor = True
        '
        'lb_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 496)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.Verlauf_2)
        Me.Controls.Add(Me.history)
        Me.Controls.Add(Me.Verlauf)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.search_tb)
        Me.Controls.Add(Me.settings_label)
        Me.Controls.Add(Me.black_bg)
        Me.Controls.Add(Me.color_bg)
        Me.Controls.Add(Me.white_bg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.green)
        Me.Controls.Add(Me.blue)
        Me.Controls.Add(Me.color_fg)
        Me.Controls.Add(Me.black)
        Me.Controls.Add(Me.homepage)
        Me.Controls.Add(Me.homepage_tb)
        Me.Controls.Add(Me.copyright)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.von)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.icons_von)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "lb_settings"
        Me.Text = "LisBrowser Gecko - Einstellungen"
        Me.TopMost = True
        CType(Me.black, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.green, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.white_bg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_bg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents icons_von As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents von As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents copyright As Label
    Friend WithEvents homepage_tb As TextBox
    Friend WithEvents homepage As Label
    Friend WithEvents black As PictureBox
    Friend WithEvents color_fg As Label
    Friend WithEvents blue As PictureBox
    Friend WithEvents green As PictureBox
    Friend WithEvents red As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents white_bg As PictureBox
    Friend WithEvents color_bg As Label
    Friend WithEvents black_bg As PictureBox
    Friend WithEvents settings_label As Label
    Friend WithEvents search As Label
    Friend WithEvents search_tb As TextBox
    Friend WithEvents version As Label
    Friend WithEvents Verlauf As ListBox
    Friend WithEvents history As Label
    Friend WithEvents Verlauf_2 As ListBox
    Friend WithEvents clear As Button
End Class
