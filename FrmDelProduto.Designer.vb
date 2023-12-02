<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDelProduto
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
        btnCadastrar = New Button()
        txtCdProd = New TextBox()
        SuspendLayout()
        ' 
        ' btnCadastrar
        ' 
        btnCadastrar.Location = New Point(113, 101)
        btnCadastrar.Name = "btnCadastrar"
        btnCadastrar.Size = New Size(75, 23)
        btnCadastrar.TabIndex = 0
        btnCadastrar.Text = "Button1"
        btnCadastrar.UseVisualStyleBackColor = True
        ' 
        ' txtCdProd
        ' 
        txtCdProd.Location = New Point(261, 99)
        txtCdProd.Name = "txtCdProd"
        txtCdProd.Size = New Size(100, 23)
        txtCdProd.TabIndex = 1
        ' 
        ' FrmDelProduto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(500, 189)
        Controls.Add(txtCdProd)
        Controls.Add(btnCadastrar)
        Name = "FrmDelProduto"
        Text = "FrmDelProduto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCadastrar As Button
    Friend WithEvents txtCdProd As TextBox
End Class
