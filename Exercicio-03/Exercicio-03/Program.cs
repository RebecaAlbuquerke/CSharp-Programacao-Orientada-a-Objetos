using System;
using System.Globalization;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var retangulo = new Retangulo();

            Console.WriteLine("Digite a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A area é igual a " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O perimetro é igual a " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A diagonal é igual a " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
