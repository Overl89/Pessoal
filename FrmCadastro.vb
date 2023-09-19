Imports System.Data.SqlClient

Public Class FrmCadastro
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringConn As String = "Server=DESKTOP-UFIGK50\SQLEXPRESS;Database=DbProdutos;Trusted_Connection=True;"
        Dim SQlConn As New SqlConnection
        Dim SQLCOmmand As New SqlCommand
        Dim Query As String = "insert into TbProduto ([NmProduto],[DescProduto]) Values('" & txtProduto.Text & "', '" & TxtDesc.Text & "');"
        SQlConn.ConnectionString = stringConn

        SQlConn.Open()
        SQLCOmmand.CommandText = Query
        SQLCOmmand.Connection = SQlConn
        SQLCOmmand.ExecuteNonQuery()
        MsgBox("ProdutoCadastrao com Sucesso!!")
        SQlConn.Close()




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtProduto.Clear()
        TxtDesc.Clear()

    End Sub
End Class