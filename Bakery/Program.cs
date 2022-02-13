using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models

{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.WriteLine("Welcome to THE BAKERY!");
      Console.WriteLine("We have Bread & Pastries, see pricing below:");
      Console.WriteLine("---------------------------------------------");
      Console.WriteLine("Bread is $5 each. Buy 2 Get 3rd free.");
      Console.WriteLine("Pastries are $2 each. Buy 2 Get 3rd for $1.");
      Console.WriteLine("---------------------------------------------");
      Console.WriteLine("Would you like to order bread or pastries?");
      string answer = Console.ReadLine();

      if(answer == "bread" || answer == "Bread" || answer == "BREAD")
      {
        Console.WriteLine("How many loaves of bread would you like?");
        string numberOfLoaves = Console.ReadLine();
        int intNumberOfLoaves = int.Parse(numberOfLoaves);
        Bread newBread = new Bread(intNumberOfLoaves);
        int costOfLoaves = newBread.SetPrice();
        Console.WriteLine("Would you like to add pastries? Yes or No");
        string done = Console.ReadLine();

        if (done == "No" || done == "no");
        {
          Console.WriteLine("Your total for the loaves comes to: $" + costOfLoaves + ".");
        }

        if (done == "yes" || done == "Yes")
        {
          Console.WriteLine("How many pastries would you like?");
          string numberOfPastries = Console.ReadLine();
          int intNumberOfPastries = int.Parse(numberOfPastries);
          Pastry newPastry = new Pastry(intNumberOfPastries);
          int costOfPastries = newPastry.SetPrice();
          int price = OrderTotal.CalculatedTotal(costOfLoaves, costOfPastries);
          Console.WriteLine("Your final order total comes to: $" + price + ".");
          }
        } else if(answer == "Pastries" || answer == "pastries")
        {
          Console.WriteLine("How many pastries would you like?");
          string numberOfPastries = Console.ReadLine();
          int intNumberOfPastries = int.Parse(numberOfPastries);
          Pastry newPastry = new Pastry(intNumberOfPastries);
          int costOfPastries = newPastry.SetPrice();
          Console.WriteLine("Your total for the pastries comes to: $" + costOfPastries + ".");
        }
      }
    }
  }
