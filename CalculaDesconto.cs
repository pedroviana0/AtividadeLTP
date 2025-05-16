using System;

class Ex4_CalculaDesconto
{
    public void Executar()
    {
        try
        {
            Console.Write("Valor original: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Percentual de desconto: ");
            double perc = double.Parse(Console.ReadLine());
            double desconto = valor * (perc / 100);
            Console.WriteLine($"Valor com desconto: {valor - desconto}");
        }
        catch
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}