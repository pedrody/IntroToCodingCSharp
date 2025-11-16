/*
 * 08. Read the buying price (cost), the desired profit percentage and
       calculate the sales price of a product.
 */
using System;
class _006_BasicOperationsQuestions08
{
  public static void Main(string[] args)
  {
    // My solution:
    // Console.Write("Buying price (cost): ");
    // double cost = Convert.ToDouble(Console.ReadLine());
    // Console.Write("Desired profit percentage: ");
    // double profitPct = Convert.ToDouble(Console.ReadLine());
    // double profit = cost * profitPct / 100;
    // double finalPrice = cost + profit;
    // Console.Write($"Sales price: {finalPrice}");

    // Professor's solution:
    Console.Write("Buying price: ");
    double buyingPrice = Convert.ToDouble(Console.ReadLine());
    Console.Write("Profit percentage: ");
    double profitPercentage = Convert.ToDouble(Console.ReadLine());
    double profit = buyingPrice * (profitPercentage / 100);
    double salesPrice = buyingPrice + profit;
    Console.WriteLine($"Profit: {profit}");
    Console.WriteLine($"Sales price: {salesPrice}");
  }
}