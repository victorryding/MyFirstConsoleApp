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
                    Console.WriteLine("Hej med dig!");
                    Console.Write("Put et tal ind her:");
                    string val = Console.ReadLine();
                    int a = Convert.ToInt32(val);
                    Console.WriteLine("Du puttede {0} ind!", a);
                    t = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du skal altså putte et tal ind!! Prøv igen");
                }
            }
        }
    }
}
