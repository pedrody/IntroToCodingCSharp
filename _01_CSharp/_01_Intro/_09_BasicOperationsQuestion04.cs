/*
 * 04. Read three integer numbers and calculate the average.
 */
using System;
class _006_BasicOperationsQuestions04
{
  public static void Main(string[] args)
  {
        // My solution:
        //Console.Write("First number: ");
        //int firstNum = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Second number: ");
        //int secondNum = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Third number: ");
        //int thirdNum = Convert.ToInt32(Console.ReadLine());
        //double average = (firstNum + secondNum + thirdNum) / (double)3;
        //Console.WriteLine($"Average: {average}");

        // Professor's solution:
        Console.Write("Number 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 3: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        double average = (number1 + number2 + (double)number3) / 3;
        Console.WriteLine($"Average = {average}");

        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }
}