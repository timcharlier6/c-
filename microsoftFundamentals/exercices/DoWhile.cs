public partial class DoWhile
{
  public static void start()
  {
    int hero = 10;
    int monster = 10;

    Random dice = new Random();

    do
    {
      int roll = dice.Next(1, 11);
      monster -= roll;
      Console.WriteLine("Hero Attacks!");
      Console.WriteLine($"Monster was damaged and lost {roll} health.");
      if (monster <= 0) continue;
      Console.WriteLine($"Monster PV: {monster}\n");


      roll = dice.Next(1, 11);
      hero -= roll;
      Console.WriteLine("Monster Attacks!");
      Console.WriteLine($"Hero was damaged and lost {roll} health.");
      if (hero <= 0) continue;
      Console.WriteLine($"Hero PV: {hero}\n");

    } while (hero > 0 && monster > 0);

    Console.WriteLine(hero > monster ? "The monster was defetead!" : "YOU DIE!");
  }
}