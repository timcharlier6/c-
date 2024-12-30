
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

class Program
{
  static void Main(string[] args)
  {
    Test();
    //HelloCSharp();
    //maxNumber();
    //reverseString();
    //Game.Play();
    //Coin.Flip();
    //ForEach.ForEachLoop([1, 2, 4]);
    //BoolCheck.hasPermission();
    //BoolBlock.start();
    //SwitchCase.start();
    //FizzBuzz.start();
    //DoWhile.start();
    //Pizza.start();
    //TryParse.start();
    //ValidEntry.start();
    //Numbers.start();
    //VariablesTypes.start();
    //DataTypesException.start();
    //Convertion.Start1();
    //Convertion.Start2();
    //ArrayOperations.SortReverse();
    //ArrayOperations.ClearResize();
    //ArrayOperations.SplitJoin();
    //ArrayOperations.ReverseSentenceChallenge();
    //ArrayOperations.ParsingChallenge();
    //FormatAlphanumeric.Basics();
    //FormatAlphanumeric.StringFormattingChallenge();
    //BuiltInStringMethods.Position();
    //BuiltInStringMethods.Position2();
    //BuiltInStringMethods.Position3();
    //BuiltInStringMethods.Position4();
    //BuiltInStringMethods.Position5();
    //BuiltInStringMethods.Position6();
    //BuiltInStringMethods.Position7();
    //BuiltInStringMethods.Modify();
    //BuiltInStringMethods.Modify2();
    //GuidedProjectDataVariables.Start();
    //Methods.Ex1();
    //Methods.Ex2();
    //Methods.Ex3();
    //Methods.Ex4();
    //Methods.Ex5();
    //Methods.Ex6();
    //Game2.Start();
    //TryCatch.Ex1();
    //TryCatch.Ex2();
    //TryCatch.Ex3();
    //TryCatch.Ex4();
    //TryCatch.Ex5();
    //TryCatch.Ex6();
    //TryCatch.Ex7();
  }

  public static void Test()
  {
    string[] names = { "John", "James", "Joan", "Jamie" };
    string concat = string.Join(", ", names);
    DateTime date = DateTime.Now;
    Console.WriteLine(date.ToString("MM/yyyy"));
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
