using System;

class Ex1_Soma
{
    public void Executar()
    {
        try
        {
            Console.Write("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado: {a + b}");
        }
        catch
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}