Imports System.Windows

Public Class Form1
    Private Sub btnFCFS_Click(sender As Object, e As EventArgs) Handles btnFCFS.Click
        Dim newForm As New FCFS()
        newForm.Show()
    End Sub

    Private Sub btnSJF_Click(sender As Object, e As EventArgs) Handles btnSJF.Click
        Dim newForm As New SJF()
        newForm.Show()
    End Sub
End Class
