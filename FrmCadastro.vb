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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TxtDesc_TextChanged(sender As Object, e As EventArgs) Handles TxtDesc.TextChanged
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub txtProduto_TextChanged(sender As Object, e As EventArgs) Handles txtProduto.TextChanged
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub
End Class