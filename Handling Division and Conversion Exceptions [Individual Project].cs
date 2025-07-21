using System;

namespace DivisionWithExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number:");
            string input2 = Console.ReadLine();

            DivideStrings(input1, input2);
        }

        static void DivideStrings(string numStr1, string numStr2)
        {
            try
            {
                int number1 = Convert.ToInt32(numStr1);
                int number2 = Convert.ToInt32(numStr2);

                int result = number1 / number2;
                Console.WriteLine($"Result: {number1} / {number2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: One or both inputs were not in the correct number format.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: One or both of the numbers are too large or too small");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occured: {ex.Message}");
            }
        }
    }
}
