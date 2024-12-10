
class Program
{
  static void Main(string[] args)
  {

    //HelloCSharp();
    //maxNumber();
    //reverseString();
    //Game.Play();
    //Coin.Flip();
    //ForEach.ForEachLoop([1, 2, 4]);
    BoolCheck.hasPermission();

  }

  public static void HelloCSharp()
  {
    // Stateless method don't need to be instanciated.
    Console.WriteLine("Hello C#!");
  }


  public static void maxNumber()
  {
    Console.WriteLine(Math.Max(100, 200));
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
