using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAreaRetangulo
{
    public class Retangulo
    {
        // Construtor
        public Retangulo()
        {
            this.Altura = 0;
            this.Base = 0;
        }
         
        // Propriedades
        // Base do retângulo
        private double baseret;

        public double Base
        {
            get { return baseret; }
            set 
            {
                if (value >= 0) baseret = value;
                else baseret = 0;
            }
        }

        // Altura do retângulo
        private double altret;

        public double Altura
        {
            get { return altret; }
            set 
            { 
                if (value >= 0) altret = value; 
                else altret = 0;
            }
        }

        // Area do retângulo
        public double Area
        {
            get { return altret * baseret; }
        }

        // Exibir dados
        public void ExibeDados()
        {
            Console.WriteLine($"Base: {this.Base}");
            Console.WriteLine($"Altura: {this.Altura}");
            Console.WriteLine($"Area: {this.Area}");
        }

    }
}
