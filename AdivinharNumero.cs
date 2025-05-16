using System;

class Ex11_AdivinharNumero
{
    public void Executar()
    {
        Random rnd = new Random();
        int num = rnd.Next(1, 11);
        int palpite = -1;
        while (palpite != num)
        {
            try
            {
                Console.Write("Adivinhe um número de 1 a 10: ");
                palpite = int.Parse(Console.ReadLine());
                if (palpite != num) Console.WriteLine("Tente novamente.");
            }
            catch
            {
                Console.WriteLine("Entrada inválida.");
            }
        }
        Console.WriteLine("Acertou!");
    }
}