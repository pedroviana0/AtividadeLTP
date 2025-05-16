using System;

class Ex2_MetrosParaMilimetros
{
    public void Executar()
    {
        try
        {
            Console.Write("Digite o valor em metros: ");
            double metros = double.Parse(Console.ReadLine());
            Console.WriteLine($"Milímetros: {metros * 1000}");
        }
        catch
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}