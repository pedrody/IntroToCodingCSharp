/*
 * 01. Read a value in miles and convert to kilometers: 1 Mile = 1.60934KM.
 */
using System;
class _006_BasicOperationsQuestions01
{
  public static void Main(string[] args)
  {
        // My solution:
        //Console.Write("Miles: ");
        //double miles = Convert.ToDouble(Console.ReadLine());
        //double kilometers = miles * 1.60934;
        //Console.WriteLine($"{miles} miles is equal to {kilometers} kilometers.");

        // Professor's solution:
        Console.Write("Value in miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double kilometers = miles * 1.60934;
        Console.WriteLine($"{miles} miles = {kilometers} Kilometers");

        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }
}