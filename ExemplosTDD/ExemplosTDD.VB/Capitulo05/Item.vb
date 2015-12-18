Namespace Capitulo05
    Public Class Item

        Public Property Descricao As String
        Public Property Quantidade As Integer
        Public Property ValorUnitario As Double

        Public Sub New (ByVal descricao As String, ByVal quantidade As Integer, ByVal valorUnitario As Double)
            Me.Descricao = descricao
            Me.Quantidade = quantidade
            Me.ValorUnitario = valorUnitario
        End Sub

        Public ReadOnly Property ValorTotal As Double
            Get
                Return ValorUnitario * Quantidade
            End Get
        End Property

    End Class
End Namespace