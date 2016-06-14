Namespace CarrinhoDeComprasCap2
    Public Class Produto
        Public Property Nome As String
        Public Property Valor As Double

        Public Sub New (ByVal nome As String, ByVal valor As Double)
            Me.Nome = nome
            Me.Valor = valor
        End Sub
    End Class
End Namespace