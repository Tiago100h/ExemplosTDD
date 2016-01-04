Namespace Capitulo04
    Public Class CalculadoraDeSalario
        Public Function CalculaSalario(ByVal funcionario As Funcionario) As Double

            If funcionario.Salario > 3000 Then
                Return funcionario.Salario * 0.8
            End If
            Return funcionario.Salario * 0.9

        End Function
    End Class
End Namespace