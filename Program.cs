
class Program
{
  static void Main(string[] args)
  {

    HelloCSharp();
    RollDice();
    playGame();
    maxNumber();
    foreachLoop();
    reverseString();

  }

  public static void HelloCSharp()
  {
    // Stateless method don't need to be instanciated.
    Console.WriteLine("Hello C#!");
  }

  public static void RollDice()
  {
    // Stateful method need to be instanciated.
    Random dice = new Random();
    int roll = dice.Next(1, 7);
    Console.WriteLine(roll);
  }

  public static void playGame()
  {
    Game game = new Game();
    game.Play();
  }

  public static void maxNumber()
  {
    Console.WriteLine(Math.Max(100, 200));
  }

  public static void foreachLoop()
  {
    ForEach forEach = new ForEach();
    int sum = forEach.ForEachLoop([30, 50, 100]);
    Console.WriteLine(sum);
  } 

  public static void reverseString()
  {
    Console.WriteLine("\n\rEnter a word to reverse then press the Enter key");
    string input;
    do
    {
      input = Console.ReadLine();
    } while (string.IsNullOrEmpty(input));
    ReverseString reverseString = new ReverseString();
    reverseString.Reverse(input);
  }

}
