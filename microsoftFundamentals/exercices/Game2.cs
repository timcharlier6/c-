public partial class Game2
{
  public static void Start()
  {
    Random random = new Random();
    Console.Clear();

    Console.WriteLine("Would you like to play? (Y/N)");
    if (ShouldPlay())
    {
      PlayGame();
    }

    bool ShouldPlay()
    {
      string response = Console.ReadLine();
      return response.ToLower().Equals("y");
    }

    void PlayGame()
    {
      var play = true;

      while (play)
      {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        // Wait for 1 second
        Thread.Sleep(1000);
        Console.WriteLine($"You rolled a {roll}");
        Thread.Sleep(1000);
        Console.WriteLine(WinOrLose(roll, target));
        Thread.Sleep(1000);
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
      }
    }

    int GetTarget()
    {
      return random.Next(1, 6);
    }

    int RollDice()
    {
      return random.Next(1, 7);
    }

    string WinOrLose(int roll, int target)
    {
      if (roll > target)
      {
        return "You win!";
      }
      return "You lose!";
    }
  }
}