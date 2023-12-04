using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedete chislo ");
            int chislo = int.Parse(Console.ReadLine());
            int dobavi;
            List<int> list = new List<int>();
            while (chislo > 0)
            {
                dobavi = chislo % 10;
                list.Add(dobavi);
                chislo = chislo / 10;
            }
            list.Reverse();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
