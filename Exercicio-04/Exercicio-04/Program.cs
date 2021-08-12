using System;
using System.Globalization;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario();

            Console.Write("Digite o nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite o salario bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Os dados do funcionário: " + funcionario);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentarSalario(porcentagem);
       
            Console.WriteLine("Dados atualizados do funcionário: " + funcionario);
        }
    }
}
