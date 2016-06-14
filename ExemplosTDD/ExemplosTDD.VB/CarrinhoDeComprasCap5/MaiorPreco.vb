Namespace Capitulo05
    Public Class MaiorPreco
        Public Function Encontra(ByVal carrinho As CarrinhoDeCompras) As Double
            If carrinho.Itens.Count() = 0 Then Return 0
            
            Dim maior = carrinho.Itens(0).ValorTotal
            For Each item In carrinho.Itens
                If maior < item.ValorTotal Then
                    maior = item.ValorTotal
                End If
            Next
            Return maior

        End Function
    End Class
End Namespace