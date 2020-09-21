Imports System.Net.Http.Headers
Imports System.Runtime.InteropServices

Public Class Form2

    Property FileLama As String
    Property FileBaru As String

    Property SheetName As String
    Property BarisMulai As Integer
    Property BarisSelesai As Integer
    Property KolomMulai As Integer
    Property KolomSelesai As Integer

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim frm As Form1 = Me.Owner
        Dim excel As Microsoft.Office.Interop.Excel.Application = Nothing
        Dim books As Microsoft.Office.Interop.Excel.Workbooks = Nothing
        Dim bookLama As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim bookBaru As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim sheetLama As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        Dim sheetBaru As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        Dim rangeLama As Microsoft.Office.Interop.Excel.Range = Nothing
        Dim rangeBaru As Microsoft.Office.Interop.Excel.Range = Nothing

        Try
            excel = New Microsoft.Office.Interop.Excel.Application
            books = excel.Workbooks
            bookLama = books.Open(Me.FileLama, [ReadOnly]:=False, IgnoreReadOnlyRecommended:=True, Editable:=True)
            sheetLama = bookLama.Worksheets.Item(Me.SheetName)
            bookBaru = books.Open(Me.FileBaru, [ReadOnly]:=False, IgnoreReadOnlyRecommended:=True, Editable:=True)
            sheetBaru = bookBaru.Worksheets.Item(Me.SheetName)

            For r = Me.BarisMulai To Me.BarisSelesai
                For c = Me.KolomMulai To Me.KolomSelesai
                    frm.lblLaporan.Text = "Baris ke: " & r & ", Kolom ke: " & c
                    frm.Refresh()
                    Application.DoEvents()
                    rangeLama = sheetLama.Cells.Item(r, c)
                    rangeBaru = sheetBaru.Cells.Item(r, c)
                    If rangeBaru.Text <> rangeLama.Text Then
                        rangeBaru.Interior.Color = Color.Red
                    End If
                Next
            Next

            bookBaru.Save()
            bookBaru.Close(SaveChanges:=False)
            bookLama.Close(SaveChanges:=False)
            excel.Quit()

            rangeLama = Nothing
            rangeBaru = Nothing
            sheetLama = Nothing
            sheetBaru = Nothing
            bookLama = Nothing
            bookBaru = Nothing
            books = Nothing
            excel = Nothing
        Catch ex As Exception
            MsgBox("Maaf, terjadi Error saat memproses file Excel!" & vbCrLf & "Lebih lanjut, pesan Error aplikasi telah dicopy di Clipboard. Anda dapat melihatnya dengan paste ke Notepad.", MsgBoxStyle.ApplicationModal And MsgBoxStyle.OkOnly, "Error")
            Clipboard.SetText(ex.ToString)
            frm.lblLaporan.Text = "Selesai dengan ERROR"
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Finally
            If rangeLama IsNot Nothing Then Marshal.ReleaseComObject(rangeLama)
            If rangeBaru IsNot Nothing Then Marshal.ReleaseComObject(rangeBaru)
            If sheetLama IsNot Nothing Then Marshal.ReleaseComObject(sheetLama)
            If sheetBaru IsNot Nothing Then Marshal.ReleaseComObject(sheetBaru)
            If bookLama IsNot Nothing Then Marshal.ReleaseComObject(bookLama)
            If bookBaru IsNot Nothing Then Marshal.ReleaseComObject(bookBaru)
            If books IsNot Nothing Then Marshal.ReleaseComObject(books)
            If excel IsNot Nothing Then Marshal.ReleaseComObject(excel)
        End Try
        frm.lblLaporan.Text = "Selesai dengan SUKSES"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class