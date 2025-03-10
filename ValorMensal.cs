using System;

class Program
{
    static void Main(string[] args)
    {
        // Faturamento mensal por estado
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        // Calcular faturamento total
        double faturamentoTotal = sp + rj + mg + es + outros;

        // Calcular os percentuais de cada estado
        double percentualSP = (sp / faturamentoTotal) * 100;
        double percentualRJ = (rj / faturamentoTotal) * 100;
        double percentualMG = (mg / faturamentoTotal) * 100;
        double percentualES = (es / faturamentoTotal) * 100;
        double percentualOutros = (outros / faturamentoTotal) * 100;

        // Exibir os resultados
        Console.WriteLine("Percentual de representação por estado:");
        Console.WriteLine($"SP: {percentualSP:F2}%");
        Console.WriteLine($"RJ: {percentualRJ:F2}%");
        Console.WriteLine($"MG: {percentualMG:F2}%");
        Console.WriteLine($"ES: {percentualES:F2}%");
        Console.WriteLine($"Outros: {percentualOutros:F2}%");
    }
}

// Saida desejadas

/*
Percentual de representação por estado:
SP: 37.53%
RJ: 20.29%
MG: 16.18%
ES: 15.03%
Outros: 10.97%
*/
