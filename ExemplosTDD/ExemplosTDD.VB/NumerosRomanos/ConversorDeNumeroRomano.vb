Namespace NumerosRomanos
    Public Class ConversorDeNumeroRomano
        Public ReadOnly Tabela As New Dictionary(Of String, Integer) From
            {{"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}}

        Public Function Converte(ByVal numeroEmRomano As String) As Integer
            Dim acumulador As Integer
            Dim ultimoVizinhoDaDireita As Integer
            For i As Integer = numeroEmRomano.Length - 1 To 0 Step -1
                'pega o inteiro referente ao simbolo atual
                Dim atual = Tabela(numeroEmRomano(i))

                'se o da direita for menor, o multiplicaremos por -1 para tornalo negativo
                Dim multiplicador = 1
                If atual < ultimoVizinhoDaDireita Then multiplicador = -1

                acumulador += atual * multiplicador

                'atualiza o vizinho da direita
                ultimoVizinhoDaDireita = atual
            Next
            Return acumulador
        End Function
    End Class
End Namespace