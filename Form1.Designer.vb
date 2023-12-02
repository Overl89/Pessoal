<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        CadastrarProdutoToolStripMenuItem = New ToolStripMenuItem()
        DeletarProdutoToolStripMenuItem = New ToolStripMenuItem()
        AlterarProdutoToolStripMenuItem = New ToolStripMenuItem()
        SairToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        RelatoriosToolStripMenuItem = New ToolStripMenuItem()
        ProdutosToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, RelatoriosToolStripMenuItem, ToolStripMenuItem2})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {CadastrarProdutoToolStripMenuItem, DeletarProdutoToolStripMenuItem, AlterarProdutoToolStripMenuItem, SairToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(61, 20)
        ToolStripMenuItem1.Text = "Arquivo"
        ' 
        ' CadastrarProdutoToolStripMenuItem
        ' 
        CadastrarProdutoToolStripMenuItem.Name = "CadastrarProdutoToolStripMenuItem"
        CadastrarProdutoToolStripMenuItem.Size = New Size(180, 22)
        CadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto"
        ' 
        ' DeletarProdutoToolStripMenuItem
        ' 
        DeletarProdutoToolStripMenuItem.Name = "DeletarProdutoToolStripMenuItem"
        DeletarProdutoToolStripMenuItem.Size = New Size(180, 22)
        DeletarProdutoToolStripMenuItem.Text = "Deletar Produto"
        ' 
        ' AlterarProdutoToolStripMenuItem
        ' 
        AlterarProdutoToolStripMenuItem.Name = "AlterarProdutoToolStripMenuItem"
        AlterarProdutoToolStripMenuItem.Size = New Size(180, 22)
        AlterarProdutoToolStripMenuItem.Text = "Alterar Produto"
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.Size = New Size(180, 22)
        SairToolStripMenuItem.Text = "Sair"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(49, 20)
        ToolStripMenuItem2.Text = "Sobre"
        ' 
        ' RelatoriosToolStripMenuItem
        ' 
        RelatoriosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProdutosToolStripMenuItem})
        RelatoriosToolStripMenuItem.Name = "RelatoriosToolStripMenuItem"
        RelatoriosToolStripMenuItem.Size = New Size(71, 20)
        RelatoriosToolStripMenuItem.Text = "Relatorios"
        ' 
        ' ProdutosToolStripMenuItem
        ' 
        ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        ProdutosToolStripMenuItem.Size = New Size(180, 22)
        ProdutosToolStripMenuItem.Text = "Produtos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        HelpButton = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        Text = "Cadastro de Produtos"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CadastrarProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AlterarProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeletarProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
End Class
