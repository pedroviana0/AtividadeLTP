using System;

class Ex5_AluguelCarro
{
    public void Executar()
    {
        try
        {
            Console.Write("Dias alugados: ");
            int dias = int.Parse(Console.ReadLine());
            Console.Write("Km percorridos: ");
            double km = double.Parse(Console.ReadLine());
            double total = dias * 90 + km * 0.20;
            Console.WriteLine($"Total a pagar: R$ {total}");
        }
        catch
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}