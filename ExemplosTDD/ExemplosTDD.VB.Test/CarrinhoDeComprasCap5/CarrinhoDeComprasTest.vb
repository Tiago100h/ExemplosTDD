
Imports ExemplosTDD.VB.CarrinhoDeComprasCap5

Namespace CarrinhoDeComprasCap5

    <TestClass()>
    Public Class CarrinhoDeComprasTest

        Shared _carrinho As CarrinhoDeCompras

        <ClassInitialize()>
        Public Shared Sub Inicializa(ByVal testContext As TestContext)
            _carrinho = New CarrinhoDeComprasBuilder().Cria()
        End Sub

        <TestMethod()>
        Public Sub DeveRetornarNothingSeCarrinhoVazio()
            Dim esperado As Item = Nothing
            Dim retornoDoTeste = _carrinho.MaiorValor()

            Assert.AreEqual(esperado, retornoDoTeste)
        End Sub

        <TestMethod()>
        Public Sub DeveRetornarItemSeCarrinhoCom1Elemento()
            _carrinho = New CarrinhoDeComprasBuilder().ComItens(900).Cria()

            Dim esperado = _carrinho.Itens(0)
            Dim retornoDoTeste = _carrinho.MaiorValor()

            Assert.AreEqual(esperado, retornoDoTeste)
        End Sub

        <TestMethod()>
        Public Sub DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
            _carrinho = New CarrinhoDeComprasBuilder().ComItens(900, 1500, 750).Cria()

            Dim esperado = _carrinho.Itens(1)
            Dim retornoDoTeste = _carrinho.MaiorValor()

            Assert.AreEqual(esperado, retornoDoTeste)
        End Sub

        <TestMethod()>
        Public Sub DeveAdicionarItens()
            _carrinho.Itens.Clear()
            Assert.AreEqual(False, _carrinho.Itens.Any())

            Dim item = New Item("Geladeira", 1, 900)
            _carrinho.Adiciona(item)

            Assert.AreEqual(1, _carrinho.Itens.Count)
            Assert.AreEqual(item, _carrinho.Itens(0))
        End Sub

    End Class
End Namespace