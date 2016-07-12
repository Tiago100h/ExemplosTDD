Namespace NotaFiscal
    Public Class NotaFiscal
        Public Property Cliente As String
        Public Property Valor As Double
        Public Property Data As Date

        Public Sub New (cliente As String, valor As Double, data As Date)
            Me.Cliente = cliente
            Me.Valor = valor
            Me.Data = data
        End Sub
    End Class
End Namespace
