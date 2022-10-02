using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                double cel, fah;//cel=섭씨온도, fah=화씨온도
                cel = double.Parse(Console.ReadLine());
                fah = 9 * cel / 5 + 32;
                Console.WriteLine(fah);


         }
    }
}
