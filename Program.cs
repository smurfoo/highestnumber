
/*  
 Purpose: Determine the highest number from three user inputted whole numbers
Input: number1, number2, number3
Output: highest
 Author: Ilyas G
Date: Sept 14 2022
 */





namespace decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int number1,
                number2,
                number3,
                highest;

            // input three numbers
            Console.Write("Enter first number: ");
                number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
                number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
                number3 = int.Parse(Console.ReadLine());

            // determine the highest
            // 1. Compare number1 to number2 => Highest
            if (number1 > number2)
            {
                highest = number1;
            }
            else
            {
                highest= number2;
            }
            // 2. Compare number3 to highest => Highest
            if (number3 > highest)
            {
                highest = number3;
            }
                // display highest
                Console.WriteLine($"The highest number is {highest}");



            Console.ReadLine();
        }
    }
}