Imports ExemplosTDD.VB.Capitulo03
<TestClass()> Public Class ConversorDeNumeroRomanoTest

    <TestMethod()> Public Sub DeveEntenderOSimboloI()
        Dim romano = New ConversorDeNumeroRomano()
        Dim numero = romano.Converte("I")
        Assert.AreEqual(1, numero)
    End Sub

    <TestMethod()> Public Sub DeveEntenderOSimboloV()
        Dim romano = New ConversorDeNumeroRomano()
        Dim numero = romano.Converte("V")
        Assert.AreEqual(5, numero)
    End Sub

    <TestMethod()> Public Sub DeveEntenderDoisSimbolosComoII()
        Dim romano = New ConversorDeNumeroRomano()
        Dim numero = romano.Converte("II")
        Assert.AreEqual(2, numero)
    End Sub

    <TestMethod()> Public Sub DeveEntenderQuatroSimbolosDoisADoisComoXXII()
        Dim romano = New ConversorDeNumeroRomano()
        Dim numero = romano.Converte("XXII")
        Assert.AreEqual(22, numero)
    End Sub

    <TestMethod()> Public Sub DeveEntenderNumerosComoIX()
        Dim romano = New ConversorDeNumeroRomano()
        Dim numero = romano.Converte("IX")
        Assert.AreEqual(9, numero)
    End Sub

    <TestMethod()> Public Sub DeveEntenderNumerosComplexosComoXXIV()
        Dim romano = New ConversorDeNumeroRomano()
        Dim numero = romano.Converte("XXIV")
        Assert.AreEqual(24, numero)
    End Sub

End Class