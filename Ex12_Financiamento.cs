using System;

class Ex12_Financiamento
{
    public void Executar()
    {
        try
        {
            Console.Write("Valor do veículo: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Meses para pagar: ");
            int meses = int.Parse(Console.ReadLine());
            Console.Write("Taxa de juros mensal (%): ");
            double juros = double.Parse(Console.ReadLine());
            double parcela = valor * Math.Pow(1 + juros / 100, meses) / meses;
            Console.WriteLine($"Parcela mensal: R$ {parcela}");
        }
        catch
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}