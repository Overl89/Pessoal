Imports System.Data.SqlClient

Public Class FrmDelProduto
    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Dim stringConn As String = "Server=DESKTOP-UFIGK50\SQLEXPRESS;Database=DbProdutos;Trusted_Connection=True;"
        Dim SQlConn As New SqlConnection
        Dim SQLCOmmand As New SqlCommand

        Dim Query As String = "delete from Tbproduto where CdProduto=" & TxtCdProd.Text & ""
        SQlConn.ConnectionString = stringConn

        SQlConn.Open()
        SQLCOmmand.CommandText = Query
        SQLCOmmand.Connection = SQlConn
        SQLCOmmand.ExecuteNonQuery()
        MsgBox("Produto Atualizado com Sucesso!!")
        SQlConn.Close()
    End Sub

    Private Sub FrmDelProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class