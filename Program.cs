using System;

namespace PlayingWithVariables
{
  class Program
  {
    static void Main(string[] args)
    {
      var numberOfCupsOfCoffee = 2;
      var fullName = "Alexa Lewis";
      var today = "2/10/2020";

      Console.WriteLine("My full name is " + fullName + " and I drink " + numberOfCupsOfCoffee + " cups of coffee everyday. " + "Today is " + today);

      Console.WriteLine("Please tell me your name");
      var userName = Console.ReadLine();

      if (userName == "Alice")
      {
        Console.WriteLine("Alice is my favorite name!");
      }
      else
      {
        Console.WriteLine("Welcome, " + userName);
      }
      Console.WriteLine("Please give me a number");
      var operand1 = Console.ReadLine();
      Console.WriteLine("Please give me another number");
      var operand2 = Console.ReadLine();
      var userSum = double.Parse(operand1) + double.Parse(operand2);
      var userDiff = double.Parse(operand1) - double.Parse(operand2);
      var userQuotient = double.Parse(operand1) / double.Parse(operand2);
      var userProduct = double.Parse(operand1) * double.Parse(operand2);
      var remainder = double.Parse(operand1) % double.Parse(operand2);

      Console.WriteLine("The sum of your two numbers is " + userSum);
      Console.WriteLine("The difference of your numbers is " + userDiff);
      Console.WriteLine("The quotient of your numbers is " + userQuotient);
      Console.WriteLine("The product of your numbers is " + userProduct);
      Console.WriteLine("The remainder of your numbers is " + remainder);

    }
  }
}
