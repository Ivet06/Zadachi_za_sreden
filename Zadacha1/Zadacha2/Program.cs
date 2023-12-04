using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chisloto n
            double n = Math.PI;
            Console.WriteLine("n=3,14");

            //Diametar
            Console.Write("d=");
            double d = double.Parse(Console.ReadLine());

            //Radios
            double r;
            r = d / 2;
            Console.WriteLine($"r={r}");

            //Visochina
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());

            //Lice
            double S;
            S = 2 * n * r * (r + h);
            Console.WriteLine($"S={S}");

            //Obem
            double V;
            V = n * r * r * h;
            Console.WriteLine($"V={V}");
        }
    }
}