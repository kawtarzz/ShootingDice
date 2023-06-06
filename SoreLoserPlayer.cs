namespace ShootingDice
{
  // TODO: Complete this class

  // A Player that throws an exception when they lose to the other player
  // Where might you catch this exception????
  public class SoreLoserPlayer
  {
    [System.Serializable]
    public class SoreLoserPlayerException : System.Exception
    {
      public SoreLoserPlayerException() { }
      public SoreLoserPlayerException(string message) : base(message) { }
      public SoreLoserPlayerException(string message, System.Exception inner) : base(message, inner) { }
      protected SoreLoserPlayerException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
  }
}