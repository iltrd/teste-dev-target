//Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
//SP – R$67.836,43
//RJ – R$36.678,66
//MG – R$29.229,88
//ES – R$27.165,48
//Outros – R$19.849,53

//Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.


using System;

class Program
{
    static void Main(string[] args)
    {
        // valores de faturamento mensal por estado
        decimal sp = 67836.43m;
        decimal rj = 36678.66m;
        decimal mg = 29229.88m;
        decimal es = 27165.48m;
        decimal outros = 19849.53m;

        // calculando o valor total mensal da distribuidora
        decimal total = sp + rj + mg + es + outros;

        // calculando o percentual de representação de cada estado
        decimal percentualSP = (sp / total) * 100;
        decimal percentualRJ = (rj / total) * 100;
        decimal percentualMG = (mg / total) * 100;
        decimal percentualES = (es / total) * 100;
        decimal percentualOutros = (outros / total) * 100;

        // imprimindo os resultados
        Console.WriteLine("Percentual de representação de cada estado no faturamento mensal:");
        Console.WriteLine($"SP: {percentualSP}%");
        Console.WriteLine($"RJ: {percentualRJ}%");
        Console.WriteLine($"MG: {percentualMG}%");
        Console.WriteLine($"ES: {percentualES}%");
        Console.WriteLine($"Outros: {percentualOutros}%");
    }
}
