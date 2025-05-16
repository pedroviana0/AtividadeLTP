using System;

class Ex9_Fatoriais
{
    public void Executar()
    {
        for (int i = 1; i <= 10; i++)
        {
            long fat = 1;
            for (int j = 2; j <= i; j++)
                fat *= j;
            Console.WriteLine($"{i}! = {fat}");
        }
    }
}