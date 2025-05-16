using System;

class Ex3_CalculaAumento
{
    public void Executar()
    {
        try
        {
            Console.Write("Salário atual: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Percentual de aumento: ");
            double perc = double.Parse(Console.ReadLine());
            double aumento = salario * (perc / 100);
            Console.WriteLine($"Novo salário: {salario + aumento}");
        }
        catch
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}