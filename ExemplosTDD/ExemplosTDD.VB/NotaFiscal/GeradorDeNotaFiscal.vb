Namespace NotaFiscal
    Public Class GeradorDeNotaFiscal

        Private ReadOnly _dao As NfDao
        Private ReadOnly _sap As Sap

        Sub New()
            _dao = New NfDao()
            _sap = New Sap()
        End Sub

        Sub New(dao As NfDao)
            _dao = dao
            _sap = New Sap()
        End Sub

        Sub New(dao As NfDao, sap As Sap)
            _dao = dao
            _sap = sap
        End Sub

        Public Function Gera(pedido As Pedido) As NotaFiscal

            Dim nf = New NotaFiscal(
                pedido.Cliente,
                pedido.ValorTotal * 0.94,
                Date.Now)

            _dao.Persiste(nf)
            _sap.Envia(nf)

            Return nf

        End Function
    End Class
End NameSpace