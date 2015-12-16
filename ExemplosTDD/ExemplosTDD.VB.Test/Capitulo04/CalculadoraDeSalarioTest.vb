Imports ExemplosTDD.VB.Capitulo04

Namespace Capitulo04
    <TestClass()> Public Class CalculadoraDeSalarioTest
        
        <TestMethod()> Public Sub DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()

            Dim calculadora = New CalculadoraDeSalario()
            Dim funcionario = New Funcionario("Mauricio", 1500, Cargo.Desenvolvedor)

            Dim salario = calculadora.CalculaSalario(funcionario)

            Assert.AreEqual(funcionario.Salario * 0.9, salario, 0.00001)
        End Sub

        <TestMethod()> Public Sub DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()

            Dim calculadora = New CalculadoraDeSalario()
            Dim funcionario = New Funcionario("Mauricio", 4000, Cargo.Desenvolvedor)

            Dim salario = calculadora.CalculaSalario(funcionario)

            Assert.AreEqual(funcionario.Salario * 0.8, salario, 0.00001)
        End Sub

        <TestMethod()> Public Sub DeveCalcularSalarioParaDbasComSalarioAbaixoDoLimite()

            Dim calculadora = New CalculadoraDeSalario()
            Dim funcionario = New Funcionario("Mauricio", 500, Cargo.Dba)

            Dim salario = calculadora.CalculaSalario(funcionario)

            Assert.AreEqual(funcionario.Salario * 0.85, salario, 0.00001)
        End Sub

    End Class
End Namespace