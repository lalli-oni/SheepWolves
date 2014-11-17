using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class Program
    {
        static List<bool> sheeps = new List<bool>();

        static void Main(string[] args)
        {
            prepareStatesList(5);
            Console.WriteLine("---");
            prepareStatesList(6);
            Console.WriteLine("---");
            prepareStatesList(7);
            Console.WriteLine("---");
            prepareStatesList(8);
            Console.WriteLine("---");
            prepareStatesList(9);
            Console.WriteLine("---");
            prepareStatesList(10);
            Console.WriteLine("---");
            prepareStatesList(11);
            Console.WriteLine("---");
            prepareStatesList(12);
            Console.WriteLine("---");
            prepareStatesList(13);
            Console.WriteLine("---");
            prepareStatesList(14);
            Console.WriteLine("---");
            Console.ReadKey();
        }

        static void prepareStatesList(decimal playerNumberPara)
        {
            for (decimal o = 0; o < playerNumberPara - (playerNumberPara * Convert.ToDecimal(0.6)); o++)
            {
                sheeps.Add(false);
            }
            for (decimal i = 0; i < playerNumberPara - (playerNumberPara / Convert.ToDecimal(3)); i++)
            {
                sheeps.Add(true);
            }
            Console.WriteLine("Total is: " + sheeps.Count);
            Console.WriteLine("Sheeps are: " + sheeps.Count(c => c));
            Console.WriteLine("Wolves are: " + sheeps.Count(c => !c));
            sheeps.Clear();
        }
    }
}
