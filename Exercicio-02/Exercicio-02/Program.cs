using System;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario1 = new Funcionario();
            var funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario2.Salario = double.Parse(Console.ReadLine());

            double salariomedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine("O salario medio é "+ salariomedio);
        }
    }
}
