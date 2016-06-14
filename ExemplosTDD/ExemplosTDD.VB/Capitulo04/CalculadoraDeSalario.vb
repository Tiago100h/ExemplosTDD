Namespace Capitulo04
    Public Class CalculadoraDeSalario
        Public Function CalculaSalario(ByVal funcionario As Funcionario) As Double
            If funcionario.Cargo = Cargo.Desenvolvedor Then
                Return DezOuVintePorCentoDeDesconto(funcionario)
            ElseIf funcionario.Cargo = Cargo.Dba Or funcionario.Cargo = Cargo.Testador Then
                Return QuinzeOuVinteCincoPorCentoDeDesconto(funcionario)
            End If
            Throw New Exception("Funcionario invalido")
        End Function

        Private Function QuinzeOuVinteCincoPorCentoDeDesconto(funcionario As Funcionario) As Double
            If funcionario.Salario < 2500 Then
                Return funcionario.Salario * 0.85
            End If
            Return funcionario.Salario * 0.75
        End Function

        Private Function DezOuVintePorCentoDeDesconto(funcionario As Funcionario) As Double
            If funcionario.Salario > 3000 Then
                Return funcionario.Salario * 0.8
            End If
            Return funcionario.Salario * 0.9
        End Function

    End Class
End Namespace