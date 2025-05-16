using System;

class Ex6_CalcularIMC
{
    public void Executar()
    {
        try
        {
            Console.Write("Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Altura (m): ");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);
            Console.WriteLine($"IMC: {imc}");
        }
        catch
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}