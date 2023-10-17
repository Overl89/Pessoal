Imports System.Data.SqlClient

Public Class FrmAtualizaProduto
    Private Sub TxtCdProd_TextChanged(sender As Object, e As EventArgs) Handles TxtCdProd.TextChanged


    End Sub

    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Dim stringConn As String = "Server=DESKTOP-UFIGK50\SQLEXPRESS;Database=DbProdutos;Trusted_Connection=True;"
        Dim SQlConn As New SqlConnection
        Dim SQLCOmmand As New SqlCommand

        Dim Query As String = "Update TbProduto set NmProduto='" & txtProduto.Text & "',DescProduto ='" & TxtDesc.Text & "'  where CdProduto=" & TxtCdProd.Text & ""
        SQlConn.ConnectionString = stringConn

        SQlConn.Open()
        SQLCOmmand.CommandText = Query
        SQLCOmmand.Connection = SQlConn
        SQLCOmmand.ExecuteNonQuery()
        MsgBox("Produto Atualizado com Sucesso!!")
        SQlConn.Close()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub
End Class