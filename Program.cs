using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Soma dois números");
            Console.WriteLine("2 - Metros para milímetros");
            Console.WriteLine("3 - Calcula aumento");
            Console.WriteLine("4 - Calcula desconto");
            Console.WriteLine("5 - Aluguel carro");
            Console.WriteLine("6 - Calcular IMC");
            Console.WriteLine("7 - Tabuada de um número");
            Console.WriteLine("8 - Múltiplos de 3 entre 0 e 10");
            Console.WriteLine("9 - Fatoriais de 1 até 10");
            Console.WriteLine("10 - Imposto de renda");
            Console.WriteLine("11 - Adivinhar número");
            Console.WriteLine("12 - Financiamento de veículo");
            Console.WriteLine("13 - Aposentadoria");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            try
            {
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: new Ex1_Soma().Executar(); break;
                    case 2: new Ex2_MetrosParaMilimetros().Executar(); break;
                    case 3: new Ex3_CalculaAumento().Executar(); break;
                    case 4: new Ex4_CalculaDesconto().Executar(); break;
                    case 5: new Ex5_AluguelCarro().Executar(); break;
                    case 6: new Ex6_CalcularIMC().Executar(); break;
                    case 7: new Ex7_Tabuada().Executar(); break;
                    case 8: new Ex8_MultiplosDe3().Executar(); break;
                    case 9: new Ex9_Fatoriais().Executar(); break;
                    case 10: new Ex10_ImpostoRenda().Executar(); break;
                    case 11: new Ex11_AdivinharNumero().Executar(); break;
                    case 12: new Ex12_Financiamento().Executar(); break;
                    case 13: new Ex13_Aposentadoria().Executar(); break;
                    case 0: return;
                    default: Console.WriteLine("Opção inválida."); break;
                }
            }
            catch
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }
        }
    }
}