using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class Program
    {
        List<bool> sheeps = new List<bool>();

        static void Main(string[] args)
        {
            decimal playerNumber = 5;
            decimal wolves;
            decimal sheep;
            decimal total;
            
        }

        void prepareStatesList(int playerNumberPara)
        {
            Convert.ToDecimal(playerNumberPara);
            for (decimal i = 0; i < playerNumberPara - playerNumberPara * Convert.ToDecimal(0.7) + 1; i++)
            {
                sheeps.Add(false);
            }
            for (decimal i = 0; i < playerNumberPara - playerNumberPara / 3; i++)
            {
                sheeps.Add(true);
            }
            Console.WriteLine("Total is: " + sheeps.Count);
            Console.WriteLine("Sheep are: " + sheeps.Count);

        }
    }
}
