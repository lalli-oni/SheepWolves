using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValue();
        }

        private static void GetValue()
        {
            int a = int.MinValue;
            int b = int.MaxValue;
            try
            {
                GetValue();
                while (a == int.MinValue || b == int.MaxValue)
                {
                    Console.WriteLine("Smallest possible integer:" + a);
                    if (a == int.MinValue)
                    {
                        Console.WriteLine("Enter the first number:");
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("------------------");
                    Console.WriteLine("Biggest possible integer:" + b);
                    if (b == int.MaxValue)
                    {
                        Console.WriteLine("Enter the second number:");
                        b = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("A divided by B: " + a/b);
                    Console.WriteLine("----------------");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("omg format out of order");
                GetValue();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("omg world imploded");
                GetValue();
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("your stack is overflowing");
            }
            catch (Exception e)
            {
                Console.WriteLine("wtf just happened?");
                Console.WriteLine(e);
                GetValue();
            }


            Console.ReadLine();
        }
    }
}
