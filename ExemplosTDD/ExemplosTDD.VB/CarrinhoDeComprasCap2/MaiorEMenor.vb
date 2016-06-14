Namespace CarrinhoDeComprasCap2
    Public Class MaiorEMenor
        Public Property Menor As Produto
        Public Property Maior As Produto

        Public Sub Encontra(carrinho As CarrinhoDeCompras)
            For Each produto As Produto In carrinho.Produtos
                If Menor Is Nothing OrElse produto.Valor < Menor.Valor
                    Menor = produto
                End If
                If Maior Is Nothing OrElse produto.Valor > Maior.Valor
                    Maior = produto
                End If
            Next
        End Sub
    End Class
End Namespace