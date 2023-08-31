using System.Text;

public class Questao2
{
    public List<Vendas> LetTxt()
    {
        string[] linhas = File.ReadAllLines(@"C:\Users\Beatriz\source\repos\Questions\Questions\ExtratoEletronicoGetNet.txt", Encoding.UTF8);

        var vendas = new List<Vendas>();

        for (int i = 0; i < linhas.Length; i++)
        {
            var linha = linhas[i];
            if (linha.StartsWith("1"))
            {
                var valorPosicao = 85;
                var valorTamanho = 11;

                var parcelaPosicao = 173;
                var parcelaTamanho = 2;

                var valor = linha.Substring(valorPosicao, valorTamanho);
                var parcelas = linha.Substring(parcelaPosicao, parcelaTamanho);

                var venda = new Vendas
                {
                    Parcelas = parcelas,
                    Valor = valor
                };

                vendas.Add(venda);
            }

        }

        return vendas;
    }
}

public class Vendas
{
    public string? Valor { get; set; }
    public string? Parcelas { get; set; }
}