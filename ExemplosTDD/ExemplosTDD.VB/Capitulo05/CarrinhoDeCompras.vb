Namespace Capitulo05
    Public Class CarrinhoDeCompras

        Public Property Itens As List(Of Item)
        
        Public Sub New ()
            Itens = New List(Of Item)()
        End Sub

        Public Sub Adiciona(ByVal item As Item)
            Itens.Add(item)
        End Sub

        Public Function MaiorValor() As Double
            If Itens.Count() = 0 Then Return 0
            
            Dim maior = Itens(0).ValorTotal
            For Each item In Itens
                If maior < item.ValorTotal Then
                    maior = item.ValorTotal
                End If
            Next
            Return maior
        End Function

    End Class
End Namespace
