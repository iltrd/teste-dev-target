//Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

//IMPORTANTE:
//a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
//b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Lê o arquivo JSON com os dados de faturamento mensal
        string json = File.ReadAllText("dados.json");
        decimal[] faturamento = JsonConvert.DeserializeObject<decimal[]>(json);

        // Calcula o menor e maior valor de faturamento
        decimal menorFaturamento = faturamento.Min();
        decimal maiorFaturamento = faturamento.Max();

        Console.WriteLine("Menor valor de faturamento: " + menorFaturamento);
        Console.WriteLine("Maior valor de faturamento: " + maiorFaturamento);

        // Calcula a média mensal, ignorando dias sem faturamento
        decimal mediaMensal = faturamento.Where(x => x > 0).Average();

        // Conta quantos dias tiveram faturamento superior à média mensal
        int diasAcimaDaMedia = faturamento.Count(x => x > mediaMensal);

        Console.WriteLine("Número de dias com faturamento acima da média mensal: " + diasAcimaDaMedia);
    }
}
