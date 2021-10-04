using System;

namespace Lab01_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }

            catch (Exception)

            {
                Console.WriteLine("I'm sorry, but something has gone terribly wrong");
            }

            finally

            {
                Console.WriteLine("Let's Go!");
            }
            
        }

        static void StartSequence()
        {
            
        }

        static int[] Populate(int[] array)
        { 
            return array;
        }

        static int GetSum(int[] array)
        {
            return 1;
        }

        static int GetProduct(int[] array, int sum)
        {
            return 1;
        }
    }
}
