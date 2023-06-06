using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A Player that throws an exception when they lose to the other player
  // Where might you catch this exception????
  public class SoreLoserPlayer : Player
  {

    public override void Play(Player other)
    {
      int otherRoll = other.Roll();
      int myRoll = otherRoll + 1;
      Console.WriteLine($"{Name} rolls a {myRoll}");
      Console.WriteLine($"{other.Name} rolls a {otherRoll}");
      if (myRoll > otherRoll)
      {
        Console.WriteLine($"{Name} Wins!");
      }
      else if (myRoll < otherRoll)
      {
        throw new soreLoserException("Wait..that didn't count. Let me go again! ");
      }
      else
      {
        Console.WriteLine($"It's a tie!");
      }
    }
  }
};