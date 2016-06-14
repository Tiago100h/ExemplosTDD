Namespace CarrinhoDeComprasCap2
    Public Class CarrinhoDeCompras
        Public Produtos As New List(Of Produto)

        Public Sub Adiciona(ByVal produto As Produto)
            Produtos.Add(produto)
        End Sub
    End Class
End Namespace