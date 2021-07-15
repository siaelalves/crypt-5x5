Public Class main
    Dim ch As String = "BRJSH"
    Dim vg As String = "AEIOU"
    Dim k As String() = {"JERQB", "CIFHU", "TKAGX", "WDMPZ", "SNOLV"}
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To k.Length - 1
            dgvChave.Rows.Add(k(i)(0), k(i)(1), k(i)(2), k(i)(3), k(i)(4))
        Next
    End Sub
    Dim et2 As String

    Private Sub cmdCript_Click(sender As Object, e As EventArgs) Handles cmdCript.Click
        txtTxtSaida.Text = ""

        Dim l, c As Integer
        l = 0
        c = 0
        For Each m As String In k
            For Each n As Char In m
                For Each p As Char In txtTxtEnt.Text.Replace(" ", "").Replace("AEIOU", "").ToUpper
                    If p = n Then
                        txtTxtSaida.Text &= ch(c) & ch(l)
                    End If
                Next
                c += 1
                If c = 4 Then c = 0
            Next
            l += 1
            If l = 4 Then l = 0
        Next
    End Sub
End Class
