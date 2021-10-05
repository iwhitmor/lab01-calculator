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
                Console.WriteLine("Thanks for playing!");
            }        
        }

        static void StartSequence()
        {

            try
            {
                Console.WriteLine("Please enter a number greater than zero");
                string input = Console.ReadLine();

                int userNumber = Convert.ToInt32(input);

                int[] userArray = new int[userNumber];

                Populate(userArray);
            }

            catch (FormatException)
            {
                Console.WriteLine("That is not a number");
            }

            catch (OverflowException)
            {
                Console.WriteLine("That number is too big");
            }
        }

        static int[] Populate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine("Please enter a number: ");
                string input = Console.ReadLine();

                int userNumber = Convert.ToInt32(input);

                array[i] = userNumber;
            } 

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
