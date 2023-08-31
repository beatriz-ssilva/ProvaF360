
public class Questao1
{
    public string RetirarCaracteresEspeciais(string texto)
    {
        var textoNovo = texto
              .Replace("É", "E")
              .Replace(".", "")
              .Replace("%", "")
              .Replace("-", "");

        return textoNovo;
    }
}
