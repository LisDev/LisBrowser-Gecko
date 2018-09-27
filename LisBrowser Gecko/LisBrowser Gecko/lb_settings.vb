Imports System.ComponentModel
Imports Gecko
Imports Gecko.Events
Public Class lb_settings
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            CType(main.tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate("https://www.freepik.com")
            My.Settings.navigate = True
            main.reload.Image = My.Resources.cancel
            Me.Close()
        Catch ex As Exception
            Dim result_ As DialogResult
            result_ = MsgBox("Fehler beim Öffnen im LisBrowser. Der Link wird nun in einem anderen Browser geöffnet.", MsgBoxStyle.Critical, MsgBoxStyle.OkCancel)
            If result_ = DialogResult.OK Then
                Process.Start("https://www.freepik.com")
            End If
        End Try
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            CType(main.tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate("https://www.flaticon.com/authors/gregor-cresnar")
            My.Settings.navigate = True
            main.reload.Image = My.Resources.cancel
            Me.Close()
        Catch ex As Exception
            Dim result_ As DialogResult
            result_ = MsgBox("Fehler beim Öffnen im LisBrowser. Der Link wird nun in einem anderen Browser geöffnet.", MsgBoxStyle.Critical, MsgBoxStyle.OkCancel)
            If result_ = DialogResult.OK Then
                Process.Start("https://www.flaticon.com/authors/gregor-cresnar")
            End If
        End Try
        Me.Close()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            CType(main.tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate("https://www.flaticon.com/authors/smashicons")
            My.Settings.navigate = True
            main.reload.Image = My.Resources.cancel
        Catch ex As Exception
            Dim result_ As DialogResult
            result_ = MsgBox("Fehler beim Öffnen im LisBrowser. Der Link wird nun in einem anderen Browser geöffnet.", MsgBoxStyle.Critical, MsgBoxStyle.OkCancel)
            If result_ = DialogResult.OK Then
                Process.Start("https://www.flaticon.com/authors/smashicons")
            End If
        End Try
        Me.Close()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Try
            CType(main.tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate("https://www.flaticon.com/")
            My.Settings.navigate = True
            main.reload.Image = My.Resources.cancel
        Catch ex As Exception
            Dim result_ As DialogResult
            result_ = MsgBox("Fehler beim Öffnen im LisBrowser. Der Link wird nun in einem anderen Browser geöffnet.", MsgBoxStyle.Critical, MsgBoxStyle.OkCancel)
            If result_ = DialogResult.OK Then
                Process.Start("https://www.flaticon.com/")
            End If
        End Try
        Me.Close()
    End Sub

    Private Sub lb_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Verlauf.DataSource = My.Settings.history
        Verlauf_2.DataSource = My.Settings.history2
        version.Text = "Version: " & My.Application.Info.Version.ToString
        copyright.Text = My.Application.Info.Copyright.ToString & ", " & My.Application.Info.CompanyName.ToString
        If My.Settings.color_bg = False Then
            Me.BackColor = Color.Black
        ElseIf My.Settings.color_bg = True Then
            Me.BackColor = SystemColors.Control
        Else
            MsgBox("Fehler beim Bestimmung der Hintegrundfarbe.", MsgBoxStyle.Critical)
        End If
        Try
            homepage_tb.Text = My.Settings.homepage
        Catch ex As Exception
            MsgBox("Fehler beim Bestimmen der Homepage." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
        Try
            search_tb.Text = My.Settings.search
        Catch ex As Exception
            MsgBox("Fehler beim Bestimmen der Suchengine." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub homepage_tb_TextChanged(sender As Object, e As EventArgs) Handles homepage_tb.TextChanged
        Try
            My.Settings.homepage = homepage_tb.Text
            My.Settings.Save()
        Catch ex As Exception
            MsgBox("Fehler beim Ändern der Homepage." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub black_Click(sender As Object, e As EventArgs) Handles black.Click
        Try
            My.Settings.color_fg = "black"
            My.Settings.Save()
            main.back.Image = My.Resources.back
            main._next.Image = My.Resources._next
            main.reload.Image = My.Resources.reload
            main.add.Image = My.Resources.add
            main.remove.Image = My.Resources.remove
            main.settings.Image = My.Resources.settings
        Catch ex As Exception
            MsgBox("Fehler beim Umstellen des Farbschemas." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub blue_Click(sender As Object, e As EventArgs) Handles blue.Click
        Try
            My.Settings.color_fg = "blue"
            My.Settings.Save()
            main.back.Image = My.Resources.back_blue
            main._next.Image = My.Resources.next_blue
            main.reload.Image = My.Resources.reload_blue
            main.add.Image = My.Resources.add_blue
            main.remove.Image = My.Resources.remove_blue
            main.settings.Image = My.Resources.settings_blue
        Catch ex As Exception
            MsgBox("Fehler beim Umstellen des Farbschemas." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub green_Click(sender As Object, e As EventArgs) Handles green.Click
        Try
            My.Settings.color_fg = "green"
            My.Settings.Save()
            main.back.Image = My.Resources.back_green
            main._next.Image = My.Resources.next_green
            main.reload.Image = My.Resources.reload_green
            main.add.Image = My.Resources.add_green
            main.remove.Image = My.Resources.remove_green
            main.settings.Image = My.Resources.settings_green
        Catch ex As Exception
            MsgBox("Fehler beim Umstellen des Farbschemas." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub red_Click(sender As Object, e As EventArgs) Handles red.Click
        Try
            My.Settings.color_fg = "red"
            My.Settings.Save()
            main.back.Image = My.Resources.back_red
            main._next.Image = My.Resources.next_red
            main.reload.Image = My.Resources.reload_red
            main.add.Image = My.Resources.add_red
            main.remove.Image = My.Resources.remove_red
            main.settings.Image = My.Resources.settings_red
        Catch ex As Exception
            MsgBox("Fehler beim Umstellen des Farbschemas." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            My.Settings.color_fg = "yellow"
            My.Settings.Save()
            main.back.Image = My.Resources.back_yellow
            main._next.Image = My.Resources.next_yellow
            main.reload.Image = My.Resources.reload_yellow
            main.add.Image = My.Resources.add_yellow
            main.remove.Image = My.Resources.remove_yellow
            main.settings.Image = My.Resources.settings_yellow
        Catch ex As Exception
            MsgBox("Fehler beim Umstellen des Farbschemas." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub white_bg_Click(sender As Object, e As EventArgs) Handles white_bg.Click
        Try
            My.Settings.color_bg = True
            My.Settings.Save()
            Me.BackColor = SystemColors.Control
            main.BackColor = SystemColors.Control
        Catch ex As Exception
            MsgBox("Fehler beim Umstellen des Farbschemas." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub black_bg_Click(sender As Object, e As EventArgs) Handles black_bg.Click
        Try
            My.Settings.color_bg = False
            My.Settings.Save()
            Me.BackColor = SystemColors.ControlDarkDark
            main.BackColor = SystemColors.ControlDarkDark
        Catch ex As Exception
            MsgBox("Fehler beim Umstellen des Farbschemas." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub search_tb_TextChanged(sender As Object, e As EventArgs) Handles search_tb.TextChanged
        Try
            My.Settings.search = search_tb.Text
            My.Settings.Save()
        Catch ex As Exception
            MsgBox("Fehler beim Ändern der Homepage." & vbCrLf & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        My.Settings.history.Clear()
        My.Settings.history2.Clear()
        My.Settings.Save()
    End Sub

    Private Sub Verlauf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Verlauf.SelectedIndexChanged
        CType(main.tabcontrol.SelectedTab.Controls.Item(0), GeckoWebBrowser).Navigate(Verlauf.SelectedItem)
    End Sub
End Class