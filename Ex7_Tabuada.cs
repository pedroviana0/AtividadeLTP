using System;

class Ex7_Tabuada
{
    public void Executar()
    {
        try
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
        }
        catch
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}