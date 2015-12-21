Imports ExemplosTDD.VB.Capitulo05
Namespace Capitulo05

    <TestClass()>
    Public Class CarrinhoDeComprasTest

        <TestMethod()>
        Public Sub DeveRetornarZeroSeCarrinhoVazio()
            Dim carrinho As New CarrinhoDeCompras

            Assert.AreEqual(0, carrinho.MaiorValor(), 0.0001)
        End Sub

        <TestMethod()>
        Public Sub DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
            Dim carrinho As New CarrinhoDeCompras
            carrinho.Adiciona(New Item("Geladeira", 1, 900))

            Assert.AreEqual(900, carrinho.MaiorValor(), 0.0001)
        End Sub

        <TestMethod()>
        Public Sub DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
            Dim carrinho As New CarrinhoDeCompras
            carrinho.Adiciona(New Item("Geladeira", 1, 900))
            carrinho.Adiciona(New Item("Fogão", 1, 1500))
            carrinho.Adiciona(New Item("Máquina de lavar", 1, 750))

            Assert.AreEqual(1500, carrinho.MaiorValor(), 0.0001)
        End Sub

    End Class
End Namespace