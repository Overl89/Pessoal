<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        TxtDesc = New TextBox()
        Label1 = New Label()
        txtProduto = New TextBox()
        BtnSair = New Button()
        btnLimpar = New Button()
        Button1 = New Button()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TxtDesc)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtProduto)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(370, 106)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dados do Item"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(124, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 3
        Label2.Text = "Descrição"
        ' 
        ' TxtDesc
        ' 
        TxtDesc.Location = New Point(124, 55)
        TxtDesc.Name = "TxtDesc"
        TxtDesc.Size = New Size(218, 23)
        TxtDesc.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 1
        Label1.Text = "Produto"
        ' 
        ' txtProduto
        ' 
        txtProduto.Location = New Point(18, 55)
        txtProduto.Name = "txtProduto"
        txtProduto.Size = New Size(100, 23)
        txtProduto.TabIndex = 0
        ' 
        ' BtnSair
        ' 
        BtnSair.Location = New Point(267, 22)
        BtnSair.Name = "BtnSair"
        BtnSair.Size = New Size(75, 23)
        BtnSair.TabIndex = 9
        BtnSair.Text = "Sair"
        BtnSair.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.Location = New Point(145, 22)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(75, 23)
        btnLimpar.TabIndex = 8
        btnLimpar.Text = "Limpar"
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(18, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "Cadastrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(BtnSair)
        GroupBox2.Controls.Add(btnLimpar)
        GroupBox2.Location = New Point(12, 124)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(370, 55)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Ações"
        ' 
        ' FrmCadastro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(394, 191)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "FrmCadastro"
        Text = "Cadastro"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents BtnSair As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
