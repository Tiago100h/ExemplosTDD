Namespace Capitulo02
    Public Class MaiorEMenor
        Public Property Menor As Produto
        Public Property Maior As Produto

        Public Sub Encontra(carrinho As CarrinhoDeCompras)
            For Each produto As Produto In carrinho.Produtos
                If Menor Is Nothing Or produto.Valor < Menor.Valor
                    Menor = produto
                ElseIf Maior Is Nothing Or produto.Valor > Maior.Valor
                    Maior = produto
                End If
            Next
        End Sub
    End Class
End Namespace