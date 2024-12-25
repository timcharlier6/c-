public partial class FormatAlphanumeric
{
  public static void Basics()
  {
    string first = "Hello";
    string second = "World";
    string result1 = string.Format("{0} {1}!", first, second);
    string result2 = string.Format("{1} {1}!", first, second);
    string result3 = string.Format("{0} {0} {1}!", first, second);
    Console.WriteLine("Composite Formatting");
    Console.WriteLine(result1);
    Console.WriteLine(result2);
    Console.WriteLine(result3);
    Console.WriteLine("String Interpolation");
    Console.WriteLine($"{first} {second}!");
    Console.WriteLine($"{second} {first}!");
    Console.WriteLine($"{first} {first} {first}!");
  }
}