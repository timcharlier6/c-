public partial class Coin {
  public static void Flip() {
    Random random = new Random();
    int flip = random.Next(0, 2);
    if (flip == 0) {
      Console.WriteLine("Heads");
    } else {
      Console.WriteLine("Tails");
    }
  }
}