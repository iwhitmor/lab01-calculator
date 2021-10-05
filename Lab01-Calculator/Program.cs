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
            catch (Exception ex)
            {
                Console.WriteLine("I'm sorry, but something has gone terribly wrong. " + ex.Message);
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
                GetSum(userArray);
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
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            if (sum < 20)
            {
                throw new ApplicationException($"Value of {sum} is too low");
            }

            return sum;
        }

        static int GetProduct(int[] array, int sum)
        {
            return 1;
        }
    }
}
