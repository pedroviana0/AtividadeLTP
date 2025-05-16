using System;

class Ex13_Aposentadoria
{
    public void Executar()
    {
        try
        {
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Anos de contribuição: ");
            int contribuicao = int.Parse(Console.ReadLine());
            if (idade >= 65 || contribuicao >= 35)
                Console.WriteLine("Pode se aposentar.");
            else
                Console.WriteLine("Ainda não pode se aposentar.");
        }
        catch
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}