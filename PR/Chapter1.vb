Imports System.Windows

Public Class Chapter1

    Dim ac As AccessControler_Chap1


#Region "イベント"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnQuestion_Click(sender As Object, e As EventArgs) Handles btnQuestion.Click

        txtQuestion.Text = "1からnまでの和を求めます。"

    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click

        Dim n As Integer
        Dim inputText As String = Me.txtN.Text

        If inputText = "" Then
            MessageBox.Show("n を入力してください。")
            Exit Sub
        End If

        If Not Integer.TryParse(inputText, n) Then
            MessageBox.Show("n には整数を入力してください。")
            Exit Sub
        End If

        ShowAnswer(n)

    End Sub

#End Region


#Region "メソッド"

    Private Sub ShowAnswer(n As Integer)

        Dim sum As Integer
        Dim i As Integer
        Dim n1 As Integer

        sum = 0
        i = 1
        n1 = n - (n - 1)

        While (i <= n)
            sum += i
            i += 1
        End While

        Me.txtResult.Text = "1から" & n & "までの和は" & sum & "です。"


    End Sub

#End Region



End Class
