/*
 * 03. Read two integer numbers A and B and print the result of all 
 *     arithmetic operations you know for A and B.
*      Operations: + - * / %
 */
using System;
class _006_BasicOperationsQuestions03
{
  public static void Main(string[] args)
  {
        // My solution:
        //Console.Write("Number A: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Number B: ");
        //int b = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"Sum: {a} + {b} = {a + b}");
        //Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
        //Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
        //Console.WriteLine($"Division: {a} / {b} = {(double)a / b}");
        //Console.WriteLine($"Remainder: {a} % {b} = {a % b}");

        // Professor's solution:
        Console.Write("A = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("B = ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A + B = {a + b}");
        Console.WriteLine($"A - B = {a - b}");
        Console.WriteLine($"A * B = {a * b}");
        Console.WriteLine($"A / B = {a / b} (Integer)");
        Console.WriteLine($"A / B = {a / (double)b} (Double)");
        Console.WriteLine($"A % B = {a % b}");

        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }
}