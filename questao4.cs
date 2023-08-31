
using System.Security.Cryptography.X509Certificates;

public class Questao4
    {
    public decimal CalcularMedia(decimal[] numeros)
    {
        var soma = numeros.Sum(numero => numero);
        var quantidade = numeros.Length;

        return soma / quantidade;
    }

    public decimal CalcularMediana(Decimal[] numeros) 
    {
     var ordenarNumeros = numeros
            .OrderBy(numero => numero)
            .ToArray();

        int valorMeio = ordenarNumeros.Count() / 2;

        if (ordenarNumeros.Count() % 2 == 0)
        {
            var mediaEntreNumerosNoCentro = (ordenarNumeros[valorMeio - 1] + ordenarNumeros[valorMeio]) / 2;
            return mediaEntreNumerosNoCentro;
        }
        else
        {
            return ordenarNumeros[valorMeio];
        }
    }
    
}