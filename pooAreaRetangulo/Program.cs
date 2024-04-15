using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAreaRetangulo
{
     class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("CALCULA A AREA DE UM RETANGULO");

            Console.Write("Informe a altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.Write("Informe a base: ");
            retangulo.Base = double.Parse(Console.ReadLine());

            retangulo.ExibeDados();

            Console.ReadKey();
        }
    }
}
