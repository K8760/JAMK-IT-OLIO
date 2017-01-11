using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
  class BlackJack
  {
    static void Main()
    {
    while (true)
    {
                Random rnd = new Random();
      int myNumber = rnd.Next(10,21);
      int theirNumber;
      System.Console.WriteLine("*** BlackJack! ***");
            //System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
            //reading and converting 
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                string teksti = System.Console.ReadLine();
                if (teksti == "exit" || teksti == "x")
                {
                    break;
                }
                theirNumber = System.Convert.ToInt32(teksti);
                //comparing that given number is valid
                if (theirNumber < 1 || theirNumber > 21)
                {
                    Console.WriteLine("The given number is out of limits, try again.");
                }
                else
                {
                //comparing
                if (theirNumber >= myNumber && theirNumber <= 21)
                {
                    System.Console.WriteLine("You win.");
                }
                else
                {
                    System.Console.WriteLine("You lose.");
                }
              }
      }
    }
  }
}