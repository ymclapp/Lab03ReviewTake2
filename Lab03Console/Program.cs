using System;

namespace Lab03Console
{
    class Program
    {
        static void Main()
        {
      int userInput, userInput1, userInput2, userInput3, product;
      String strValue, hardCoded;

      Console.WriteLine("Please enter a number:  ");
      strValue = Console.ReadLine();
      userInput1 = Convert.ToInt32(strValue);

      Console.WriteLine("Please enter another number:  ");
      strValue = Console.ReadLine();
      userInput2 = Convert.ToInt32(strValue);

      Console.WriteLine("Please enter your last number:  ");
      strValue = Console.ReadLine();
      userInput3 = Convert.ToInt32(strValue);

      product = userInput1 * userInput2 * userInput3;
      Console.WriteLine($"The product of those numbers is: {product} ");

      hardCoded = "1 2 3";
      //Console.WriteLine("Please enter three numbers separated by a space (ex. 1 2 3):  ");
      //strValue = Console.ReadLine();
      String [] hardCode = hardCoded.Split(" ");
      //userInput = Convert.ToInt32(inputSplit);
      foreach(var number in hardCode)
      {
        Console.WriteLine(hardCode);
      }
     

        }
    }
}
