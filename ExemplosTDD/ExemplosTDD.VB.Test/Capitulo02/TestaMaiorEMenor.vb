Imports ExemplosTDD.VB.Capitulo02

Namespace Capitulo02
    <TestClass()> Public Class TestaMaiorEMenor

        <TestMethod()> Public Sub OrdemDecresecente()
            Dim carrinho = New CarrinhoDeCompras()
            carrinho.Adiciona(New Produto("Geladeira", 450.0))
            carrinho.Adiciona(New Produto("Liquidificador", 250.0))
            carrinho.Adiciona(New Produto("Jogo de pratos", 70.0))

            Dim algoritimo = New MaiorEMenor()
            algoritimo.Encontra(carrinho)

            Assert.AreEqual("Jogo de pratos", algoritimo.Menor.Nome)
            Assert.AreEqual("Geladeira", algoritimo.Maior.Nome)
        End Sub

        <TestMethod> Public Sub ApenasUmProduto()
            Dim carrinho = New CarrinhoDeCompras()
            Dim geladeira = New Produto("Geladeira", 450.0)
            carrinho.Adiciona(geladeira)

            Dim algoritimo = New MaiorEMenor()
            algoritimo.Encontra(carrinho)

            Assert.AreEqual(geladeira, algoritimo.Menor)
            Assert.AreEqual(geladeira, algoritimo.Maior)
        End Sub

    End Class
End Namespace