using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Herencia_André_Santivañez
{
    abstract class Forma
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        public override string ToString()
        {   
            // F2 permite redondear los decimales, para que en este caso en la salida solo hayan 2 decimales.
            return $"Forma con área: {CalcularArea():F2} y perímetro: {CalcularPerimetro():F2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
