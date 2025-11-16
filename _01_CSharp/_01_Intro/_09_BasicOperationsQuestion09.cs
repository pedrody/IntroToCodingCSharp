/*
 * 09. Read the buying price (cost), the desired profit percentage and the sales tax % and
 *     calculate the final sales price of a product.
 */
using System;
class _006_BasicOperationsQuestions09
{
  public static void Main(string[] args)
  {
    // My solution:
    // Console.Write("Buying price (cost): ");
    // double cost = Convert.ToDouble(Console.ReadLine());
    // Console.Write("Desired profit (%): ");
    // double profitPct = Convert.ToDouble(Console.ReadLine());
    // double profit = cost * profitPct / 100;
    // Console.Write("Sales tax (%): ");
    // double taxPct = Convert.ToDouble(Console.ReadLine());
    // double tax = (cost + profit) * taxPct / 100;
    // double finalPrice = cost + profit + tax;
    // Console.WriteLine($"Final sales price: {finalPrice}");

    // Professor's solution:
    Console.Write("Buying price: ");
    double buyingPrice = Convert.ToDouble(Console.ReadLine());
    Console.Write("Profit percentage: ");
    double profitPercentage = Convert.ToDouble(Console.ReadLine());
    Console.Write("Sales tax percentage: ");
    double salesTaxPercentage = Convert.ToDouble(Console.ReadLine());

    double profit = buyingPrice * (profitPercentage / 100);
    double salesPrice = buyingPrice + profit;
    double salesTax = salesPrice * (salesTaxPercentage / 100);
    double finalSalesPrice = salesPrice + salesTax;

    Console.WriteLine($"Profit: {profit}");
    Console.WriteLine($"Sales tax: {salesTax}");
    Console.WriteLine($"Final sales price: {finalSalesPrice}");
  }
}