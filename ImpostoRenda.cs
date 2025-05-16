using System;

class Ex10_ImpostoRenda
{
    public void Executar()
    {
        try
        {
            Console.Write("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());
            double imposto = salario <= 1903.98 ? 0 :
                             salario <= 2826.65 ? salario * 0.075 :
                             salario <= 3751.05 ? salario * 0.15 :
                             salario <= 4664.68 ? salario * 0.225 :
                             salario * 0.275;
            Console.WriteLine($"Imposto: R$ {imposto}");
        }
        catch
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}