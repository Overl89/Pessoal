Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration
Imports System.Data
Imports System.Windows.Forms
Imports System.IO

Public Class FrmRelatorios
    Private Sub FrmRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim stringConn As String = "Server=DESKTOP-UFIGK50\SQLEXPRESS;Database=DbProdutos;Trusted_Connection=True;"
        Dim SQlConn As New SqlConnection

        Dim cmd As New SqlCommand("SELECT * From TbProduto", SQlConn)
        SQlConn.ConnectionString = stringConn
        SQlConn.Open()
        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)

        DataGridView1.DataSource = table
        SQlConn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As DataTable = New DataTable()
        For Each column As DataGridViewTextBoxColumn In DataGridView1.Columns
            dt.Columns.Add(column.Name, column.ValueType)
        Next
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim dr As DataRow = dt.NewRow()
            For Each column As DataGridViewTextBoxColumn In DataGridView1.Columns
                If row.Cells(column.Name).Value IsNot Nothing Then
                    dr(column.Name) = row.Cells(column.Name).Value.ToString()
                End If
            Next
            dt.Rows.Add(dr)
        Next
        Dim filePath As String = "C:\Users\vando\Desktop\Relatorio.txt"
        DataTableToTextFile(dt, filePath)
    End Sub

    Private Sub DataTableToTextFile(ByVal dt As DataTable, ByVal outputFilePath As String)
        Dim maxLengths As Integer() = New Integer(dt.Columns.Count - 1) {}
        For i As Integer = 0 To dt.Columns.Count - 1
            maxLengths(i) = dt.Columns(i).ColumnName.Length
            For Each row As DataRow In dt.Rows
                If Not row.IsNull(i) Then
                    Dim length As Integer = row(i).ToString().Length
                    If length > maxLengths(i) Then
                        maxLengths(i) = length
                    End If
                End If
            Next
        Next
        Using sw As StreamWriter = New StreamWriter(outputFilePath, False)
            For i As Integer = 0 To dt.Columns.Count - 1
                sw.Write(dt.Columns(i).ColumnName.PadRight(maxLengths(i) + 2))
            Next
            sw.WriteLine()
            For Each row As DataRow In dt.Rows
                For i As Integer = 0 To dt.Columns.Count - 1
                    If Not row.IsNull(i) Then
                        sw.Write(row(i).ToString().PadRight(maxLengths(i) + 2))
                    Else
                        sw.Write(New String(" "c, maxLengths(i) + 2))
                    End If
                Next
                sw.WriteLine()
            Next
            sw.Close()
        End Using
        MsgBox("Relatorio gerado com sucesso!")
    End Sub
End Class