public partial class BoolBlock
{
  public static void start()
  {
    int[] numbers = { 4, 8, 15, 16, 23, 42 };
    // declaration outside of the Block scope
    int total = 0;
    bool found = false;

    foreach (int number in numbers)
    {

      total += number;

      if (number == 42)
        found = true;

    }

    if (found)
      Console.WriteLine("Set contains 42");

    Console.WriteLine($"Total: {total}");
  }
}