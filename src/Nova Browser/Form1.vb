Imports System.ComponentModel

Public Class Form1
    Private Sub SavePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavePageToolStripMenuItem.Click
        WebBrowser1.ShowSaveAsDialog()
    End Sub

    Private Sub PrintPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPageToolStripMenuItem.Click
        WebBrowser1.ShowPrintPreviewDialog()
    End Sub

    Private Sub ShowPagePropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowPagePropertiesToolStripMenuItem.Click
        WebBrowser1.ShowPropertiesDialog()
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        WebBrowser1.ShowPageSetupDialog()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If (FormWindowState.Minimized = True) Then
            NotifyIcon1.ShowBalloonTip(5000, "Nova Browser", "Document has completed loading.", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub WebBrowser1_DocumentTitleChanged(sender As Object, e As EventArgs) Handles WebBrowser1.DocumentTitleChanged
        Text = "Nova Browser - " + WebBrowser1.DocumentTitle
    End Sub

    Private Sub WebBrowser1_StatusTextChanged(sender As Object, e As EventArgs) Handles WebBrowser1.StatusTextChanged
        ToolStripStatusLabel1.Text = WebBrowser1.StatusText
    End Sub

    Private Sub WebBrowser1_FileDownload(sender As Object, e As EventArgs) Handles WebBrowser1.FileDownload
        NotifyIcon1.ShowBalloonTip(5000, "Nova Browser", "Downloading files on Nova Browser isn't supported, so your OS's default downloader is being used.", ToolTipIcon.Warning)
    End Sub

    Private Sub WebBrowser1_EncryptionLevelChanged(sender As Object, e As EventArgs) Handles WebBrowser1.EncryptionLevelChanged
        If (WebBrowser1.EncryptionLevel = 0) Then
            NotifyIcon1.ShowBalloonTip(5000, "Nova Browser", "Your connection is insecured for now on. Be careful.", ToolTipIcon.Warning)
        End If
        If (WebBrowser1.EncryptionLevel = 1) Then
            NotifyIcon1.ShowBalloonTip(5000, "Nova Browser", "Your connection is secured for now on.", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub WebBrowser1_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser1.NewWindow
        NotifyIcon1.ShowBalloonTip(5000, "Nova Browser", "Making new tabs/windows aren't supported by Nova Browser.", ToolTipIcon.Warning)
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        NotifyIcon1.ShowBalloonTip(3000, "Nova Browser", "Thank you for using Nova Browser", ToolTipIcon.None)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        WebBrowser1.Navigate(ToolStripComboBox1.Text)
    End Sub


End Class