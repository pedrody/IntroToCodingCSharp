/*
Definition of VARIABLE

Curiosity:
- How a computer stores data:
  - A number
    - Binary numbers
  - A letter/character
      - ASCII
      - Unicode
  - What about all different types of information?
    - Image
    - Sound
    - Video

Types
 Built-in or Primitive Types:
 - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
 - int
 - double
 - char
 - bool

 String:
 - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
 - It is a class (Reference type)
 - It is immutable
 - Most used type

 Variable Declaration
   TYPE NAME

 Assignment
   NAME = VALUE or EXPRESSION

 */

using System;
class VariablesAndTypes
{
  public static void Main(string[] args)
  {
        int age = 50;
        // System.Int32 age = 50;
        Console.WriteLine(age);
        Console.WriteLine($"int.MinValue = {int.MinValue}");
        Console.WriteLine($"int.MaxValue = {int.MaxValue}");

        bool approved = true;
        // approved = false;
        Console.WriteLine(approved ? "You was approved" : "You was not approved");
        Console.WriteLine(approved);

        double height = 1.95;
        Console.WriteLine(height);

        char c = 'a';
        Console.WriteLine(c);

        string name = "Jose Azevedo";
        Console.WriteLine(name);

        string jsonString = """
            {
              "Date": "2019-08-01T00:00:00-07:00",
              "TemperatureCelsius": 25,
              "Summary": "Hot",
              "DatesAvailable": [
                "2019-08-01T00:00:00-07:00",
                "2019-08-02T00:00:00-07:00"
              ],
              "TemperatureRanges": {
                "Cold": {
                  "High": 20,
                  "Low": -10
                },
                "Hot": {
                  "High": 60,
                  "Low": 20
                }
                        },
              "SummaryWords": [
                "Cool",
                "Windy",
                "Humid"
              ]
            }
            """;
        Console.WriteLine(jsonString);

        Person p = new Person();
        p.Name = "Jose Azevedo (from Person)";
        Console.WriteLine(p.Name);
    }
}

class Person {
    public string Name;
}
