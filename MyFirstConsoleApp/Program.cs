using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            while (t)
            {
                try
                {
                    Console.WriteLine("Hej med dig! \nDette program kan kvadratrode af et indtastet tal!");
                    Console.Write("Put et tal ind her: \n");
                    string val = Console.ReadLine();
                    double a = Math.Sqrt(Convert.ToDouble(val));
                    Console.WriteLine("Kvadratroden af {0} er {1}!", val,a);
                    t = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du skal altså putte et tal ind!! Prøv igen!");
                }
            }
        }
    }
}
