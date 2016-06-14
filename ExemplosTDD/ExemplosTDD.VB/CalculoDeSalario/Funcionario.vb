Namespace CalculoDeSalario
    Public Enum Cargo
        Desenvolvedor
        Dba
        Testador
    End Enum
    Public Class Funcionario
        Public Property Nome As String
        Public Property Salario As Double
        Public Property Cargo As Cargo

        Public Sub New (ByVal nome As String, ByVal salario As Double, ByVal cargo As Cargo)
            Me.Nome = nome
            Me.Salario = salario
            Me.Cargo = cargo
        End Sub
    End Class
End Namespace