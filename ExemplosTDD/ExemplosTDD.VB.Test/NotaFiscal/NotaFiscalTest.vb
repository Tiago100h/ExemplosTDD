Imports ExemplosTDD.VB.NotaFiscal
Imports Moq

Namespace NotaFiscal

    <TestClass()>
    Public Class NotaFiscalTest

        <TestMethod()>
        Public Sub DeveGerarNfComValorDeImpostosDescontado()

            'Cenário
            Dim gerador = New GeradorDeNotaFiscal()
            Dim pedido = New Pedido("Mauricio", 1000, 1)

            'Ação
            Dim nf = gerador.Gera(pedido)

            'Verificão
            Assert.AreEqual(1000 * 0.94, nf.Valor)

        End Sub

        <TestMethod()>
        Public Sub DevePersistirNfGerada()

            'Cenário
            Dim dao = New Mock(Of NfDao) 'criando mock
            Dim gerador = New GeradorDeNotaFiscal(dao.Object)
            Dim pedido = New Pedido("Mauricio", 1000, 1)

            'Ação
            Dim nf = gerador.Gera(pedido)

            'Verificão
            dao.Verify(Sub(t) t.Persiste(nf))

        End Sub

        <TestMethod()>
        Public Sub DeveEnviarNfGeradaParaSap()

            'Cenário
            Dim dao = New Mock(Of NfDao)
            Dim sap = New Mock(Of Sap)
            Dim gerador = New GeradorDeNotaFiscal(dao.Object, sap.Object)
            Dim pedido = New Pedido("Mauricio", 1000, 1)

            'Ação
            Dim nf = gerador.Gera(pedido)

            'Verificão
            sap.Verify(Sub(t) t.Envia(nf))

        End Sub
        
    End Class

End NameSpace