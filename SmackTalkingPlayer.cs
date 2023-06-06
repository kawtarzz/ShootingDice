using System;
namespace ShootingDice
{
  // TODO: Complete this class

  // A Player who shouts a taunt every time they roll dice
  public class SmackTalkingPlayer : Player
  {
    public SmackTalkingPlayer(string taunt)
    {
      Taunt = taunt;
    }
    public string Taunt { get; }

    public override int Roll()
    {
      Console.WriteLine($"{base.Name} says {Taunt}");
      return base.Roll();
    }
  }
}