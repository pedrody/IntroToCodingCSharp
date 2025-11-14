/*
 * 02. Read an integer number and print the three predecessors and successors.
 */
using System;
class _006_BasicOperationsQuestions02
{
  public static void Main(string[] args)
  {
        // My soloution:
        //Console.Write("Type a number: ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"{n - 3} {n - 2} {n - 1} {n} {n + 1} {n + 2} {n + 3}");

        // Professor's solution:
        Console.Write("Type a integer number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"predecessors: {number - 3} {number - 2} {number - 1} ");
        Console.WriteLine($"successors: {number + 1} {number + 2 } {number + 3}");

        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }
}