using System;
using System.Collections.Generic;

namespace RPSHands.Objects
{
  public class RPSHand
  {
    public string user1;
    public string user2;
    public string output;

    public void Output(string input1, string input2)
    {
      user1 = input1;
      user2 = input2;

      if (user1 == "rock" && user2 == "scissors" || user1 == "paper" && user2 == "rock" || user1 == "scissors" && user2 == "paper")
      {
        output = "user1 wins";
        Console.WriteLine(output);
      }
      else
      {
        output = "user2 wins";
      }
    }
  }
}
