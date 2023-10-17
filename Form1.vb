Imports System.Data.SqlClient

Public Class Form1
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CadastrarProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarProdutoToolStripMenuItem.Click
        FrmCadastro.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub AlterarProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarProdutoToolStripMenuItem.Click
        FrmAtualizaProduto.Show()
    End Sub
End Class
