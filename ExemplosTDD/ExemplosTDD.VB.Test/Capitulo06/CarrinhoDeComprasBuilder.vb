Imports ExemplosTDD.VB.Capitulo05
Namespace Capitulo06
    Public Class CarrinhoDeComprasBuilder
        Dim carrinho As CarrinhoDeCompras

        Public Sub New ()
            carrinho = new CarrinhoDeCompras()
        End Sub

        Public Function ComItens (ByVal ParamArray valores() As Double) As CarrinhoDeComprasBuilder
            For Each valor In valores
                carrinho.Adiciona(New Item("item", 1, valor))
            Next
            Return Me
        End Function

        Public Function Cria() As CarrinhoDeCompras
            Return carrinho
        End Function

    End Class
End NameSpace