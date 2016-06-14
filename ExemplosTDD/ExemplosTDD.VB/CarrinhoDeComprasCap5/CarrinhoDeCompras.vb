Namespace Capitulo05
    Public Class CarrinhoDeCompras

        Public Property Itens As List(Of Item)
        
        Public Sub New ()
            Itens = New List(Of Item)()
        End Sub

        Public Sub Adiciona(ByVal item As Item)
            Itens.Add(item)
        End Sub

        Public Function MaiorValor() As Item
            If Itens.Count() = 0 Then Return Nothing
            
            Dim maior = Itens(0)
            For Each item In Itens
                If maior.ValorTotal < item.ValorTotal Then
                    maior = item
                End If
            Next
            Return maior
        End Function

    End Class
End Namespace
