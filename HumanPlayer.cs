using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A player the prompts the user to enter a number for a roll
  public class HumanPlayer : Player
  {
    public override void Play(Player user)
    {
      Console.WriteLine("Ready to Roll? What's your name, player?");
      Name = Console.ReadLine();
      Console.WriteLine($"Hello, {Name}! Enter a number to roll the dice!");
      int userRoll = Int32.Parse(Console.ReadLine());
      Console.WriteLine($"{Name} rolled a {userRoll}!");
    }
  }
}