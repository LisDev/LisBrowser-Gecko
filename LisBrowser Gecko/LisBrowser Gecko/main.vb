Imports Gecko
Imports Gecko.Events
Public Class main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newTab()
        If My.Settings.color_fg = "black" Then
            Try
                back.Image = My.Resources.back
                _next.Image = My.Resources._next
                reload.Image = My.Resources.reload
                add.Image = My.Resources.add
                remove.Image = My.Resources.remove
                settings.Image = My.Resources.settings
            Catch ex As Exception
                MsgBox("Fehler beim Einstellen des Farbschemas.", MsgBoxStyle.Critical)
            End Try
        ElseIf My.Settings.color_fg = "blue" Then
            Try
                back.Image = My.Resources.back_blue
                _next.Image = My.Resources.next_blue
                reload.Image = My.Resources.reload_blue
                add.Image = My.Resources.add_blue
                remove.Image = My.Resources.remove_blue
                settings.Image = My.Resources.settings_blue
            Catch ex As Exception
                MsgBox("Fehler beim Einstellen des Farbschemas.", MsgBoxStyle.Critical)
            End Try
        ElseIf My.Settings.color_fg = "green" Then
            Try
                back.Image = My.Resources.back_green
                _next.Image = My.Resources.next_green
                reload.Image = My.Resources.reload_green
                add.Image = My.Resources.add_green
                remove.Image = My.Resources.remove_green
                settings.Image = My.Resources.settings_green
            Catch ex As Exception
                MsgBox("Fehler beim Einstellen des Farbschemas.", MsgBoxStyle.Critical)
            End Try
        ElseIf My.Settings.color_fg = "red" Then
            Try
                back.Image = My.Resources.back_red
                _next.Image = My.Resources.next_red
                reload.Image = My.Resources.reload_red
                add.Image = My.Resources.add_red
                remove.Image = My.Resources.remove_red
                settings.Image = My.Resources.settings_red
            Catch ex As Exception
                MsgBox("Fehler beim Einstellen des Farbschemas.", MsgBoxStyle.Critical)
            End Try
        ElseIf My.Settings.color_fg = "yellow" Then
            Try
                back.Image = My.Resources.back_yellow
                _next.Image = My.Resources.next_yellow
                reload.Image = My.Resources.reload_yellow
                add.Image = My.Resources.add_yellow
                remove.Image = My.Resources.remove_yellow
                settings.Image = My.Resources.settings_yellow
            Catch ex As Exception
                MsgBox("Fehler beim Einstellen des Farbschemas.", MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Fehler beim Erkennen des Farbschemas.", MsgBoxStyle.Critical)
        End If
        If My.Settings.color_bg = False Then
            Me.BackColor = SystemColors.ControlDarkDark
            lb_settings.BackColor = SystemColors.ControlDarkDark
        ElseIf My.Settings.color_bg = True Then
            Me.BackColor = SystemColors.Control
            lb_settings.BackColor = SystemColors.Control
        Else
            MsgBox("Fehler beim Bestimmung der Hintegrundfarbe.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles add.Click
        newTab()
    End Sub
    Private Sub newTab()
        Try
            Dim newTab As New TabPage()
            newTab.Text = "Neuer Tab"
            tabcontrol.TabPages.Add(newTab)
            tabcontrol.SelectedTab = newTab
            Dim geckoWebbrowser As New GeckoWebBrowser()
            geckoWebbrowser.Dock = DockStyle.Fill
            geckoWebbrowser.Navigate(My.Settings.homepage)
            newTab.Controls.Add(geckoWebbrowser)
            AddHandler geckoWebbrowser.DocumentTitleChanged, AddressOf geckoWebbrowser_DocumentTitleChanged
            AddHandler geckoWebbrowser.DocumentCompleted, AddressOf geckoWebbrowser_DocumentCompleted
        Catch ex As Exception
            MsgBox("Fehler beim Erstellen des Tabs.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub removeButton_Click(sender As Object, e As EventArgs) Handles remove.Click
        Try
            tabcontrol.TabPages.Remove(tabcontrol.SelectedTab)
        Catch ex As Exception
            MsgBox("Fehler beim Löschen des Tabs.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub back_Click_1(sender As Object, e As EventArgs) Handles back.Click
        If CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).CanGoBack Then
            CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).GoBack()
        End If
    End Sub

    Private Sub _next_Click(sender As Object, e As EventArgs) Handles _next.Click
        If CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).CanGoForward Then
            CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).GoForward()
        End If
    End Sub

    Private Sub reload_Click(sender As Object, e As EventArgs) Handles reload.Click
        If My.Settings.refresh = False Then
            My.Settings.refresh = True
            refresh_()
            My.Settings.refresh = False
        ElseIf My.Settings.refresh = True Then
            CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).GoBack()
        Else
            MsgBox("Fehler beim Bestimmen ob der Browser bereits neu lädt.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub refresh_()
        Try
            Dim actualUrl As String = CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Url.ToString
            reload.Image = My.Resources.cancel
            CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate(actualUrl)
        Catch ex As Exception
            MsgBox("Fehler beim Neuladen der Website.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub settings_Click(sender As Object, e As EventArgs) Handles settings.Click
        Try
            lb_settings.Show()
        Catch ex As Exception
            MsgBox("Fehler beim Öffnen einer neuen Form.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub geckoWebbrowser_DocumentTitleChanged()
        Try
            tabcontrol.SelectedTab.Text = CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).DocumentTitle
        Catch ex As Exception
            MsgBox("Fehler bei der Bennenung des Tabs.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub geckoWebbrowser_DocumentCompleted()
        Try
            reload.Image = My.Resources.reload
            search_fg.Text = CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Url.ToString
        Catch ex As Exception
            MsgBox("Fehler bei der Aktualisierung der Url in der Eingabezeile.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub search_fg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search_fg.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                Dim entry As String = search_fg.Text
                If entry.Contains(" ") Then
                    CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate(My.Settings.search & entry)
                Else
                    If entry.Contains(".") Then
                        CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate(entry)
                    Else
                        CType(tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate(My.Settings.search & entry)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Fehler beim Überprüfen der Tasteneingabe oder der Texteingabe.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub search_fg_Click(sender As Object, e As EventArgs) Handles search_fg.Click
        Try
            search_fg.Text = ""
        Catch ex As Exception
            MsgBox("Fehler beim Leeren der Eingabezeile.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
