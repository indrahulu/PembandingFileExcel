Public Class Form1

    Private appName As String = My.Application.Info.ProductName
    Private section As String = My.Application.Info.Version.ToString

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLaporan.Text = ""
        txtFileLama.Text = GetSetting(appName, section, "FileLama", "")
        txtFileBaru.Text = GetSetting(appName, section, "FileBaru")
        txtSheetName.Text = GetSetting(appName, section, "Sheet")
        numBarisMulai.Value = CInt(GetSetting(appName, section, "BarisMulai", "1"))
        numBarisSelesai.Value = CInt(GetSetting(appName, section, "BarisSelesai", "10"))
        numKolomMulai.Value = CInt(GetSetting(appName, section, "KolomMulai", "1"))
        numKolomSelesai.Value = CInt(GetSetting(appName, section, "KolomSelesai", "10"))
    End Sub

    Private Sub btnPilihFileLama_Click(sender As Object, e As EventArgs) Handles btnPilihFileLama.Click
        If dlgPilihFile.ShowDialog = DialogResult.OK Then
            txtFileLama.Text = dlgPilihFile.FileName
        End If
    End Sub

    Private Sub btnPilihFileBaru_Click(sender As Object, e As EventArgs) Handles btnPilihFileBaru.Click
        If dlgPilihFile.ShowDialog = DialogResult.OK Then
            txtFileBaru.Text = dlgPilihFile.FileName
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub btnMulai_Click(sender As Object, e As EventArgs) Handles btnMulai.Click
        If txtFileLama.TextLength < 1 Or txtFileBaru.TextLength < 1 Then Exit Sub
        If txtFileLama.Text = txtFileBaru.Text Then Exit Sub
        If Not txtFileLama.Text.ToLower.EndsWith(".xlsx") And Not txtFileBaru.Text.ToLower.EndsWith(".xlsx") Then Exit Sub
        If numBarisSelesai.Value <= numBarisMulai.Value Then Exit Sub
        If numKolomSelesai.Value <= numKolomMulai.Value Then Exit Sub

        SaveSetting(appName, section, "FileLama", txtFileLama.Text)
        SaveSetting(appName, section, "FileBaru", txtFileBaru.Text)
        SaveSetting(appName, section, "Sheet", txtSheetName.Text)
        SaveSetting(appName, section, "BarisMulai", numBarisMulai.Value.ToString)
        SaveSetting(appName, section, "BarisSelesai", numBarisSelesai.Value.ToString)
        SaveSetting(appName, section, "KolomMulai", numKolomMulai.Value.ToString)
        SaveSetting(appName, section, "KolomSelesai", numKolomSelesai.Value.ToString)

        lblLaporan.Text = ""
        Dim f = New Form2
        f.FileLama = txtFileLama.Text
        f.FileBaru = txtFileBaru.Text
        f.SheetName = txtSheetName.Text
        f.BarisMulai = numBarisMulai.Value
        f.BarisSelesai = numBarisSelesai.Value
        f.KolomMulai = numKolomMulai.Value
        f.KolomSelesai = numKolomSelesai.Value
        f.ShowDialog(Me)

        txtFileLama.SelectAll()
        txtFileLama.Select()
    End Sub

End Class