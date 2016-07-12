Namespace NotaFiscal

    Public Class Pedido

        Public Property Cliente As String
        Public Property ValorTotal As Double
        Public Property QuantidadeItens As Integer

        Public Sub New (cliente As String, valorTotal As Double, quantidadeItens As Integer)
            Me.Cliente = cliente
            Me.ValorTotal = valorTotal
            Me.QuantidadeItens = quantidadeItens
        End Sub

    End Class

End NameSpace