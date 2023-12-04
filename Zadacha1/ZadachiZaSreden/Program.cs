using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachiZaSreden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strani
            double a, b, c;
            do
            {
                Console.Write("a=");
                a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                b = double.Parse(Console.ReadLine());
                Console.Write("c=");
                c = double.Parse(Console.ReadLine());

            } while ((a + b) < c || (a + c) < b || (b + c) < a);

            //Perimetar
            double P;
            P = a + b + c;
            Console.WriteLine($"P={P}");

            //Polyperimetar
            double p;
            p = P / 2;
            Console.WriteLine($"p={p}");

            //Lice
            double S;
            S = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            Console.WriteLine($"S={S}");
        }
    }
}
