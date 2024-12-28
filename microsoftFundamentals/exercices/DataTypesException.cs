public partial class DataTypesException
{
  public static void start()
  {
    int first = 2;
    string second = "4";
    //Console.WriteLine("No Conversion");
    //int myInt = first + second;
    // This line will throw an exception:
    //Console.WriteLine(myInt);
    Console.WriteLine("Implicit Conversion");
    string myString = first + second;
    Console.WriteLine($"int : {first} + string : {second}");
    Console.WriteLine($"string : {myString}");

    Console.WriteLine("Implicit Conversion");
    int myInt = 3;
    Console.WriteLine($"int : {first}");
    decimal myDecimal = myInt;
    Console.WriteLine($"decimal : {myDecimal}");

    Console.WriteLine("Explicit Conversion");
    myDecimal = 1.23456789m;
    Console.WriteLine($"decimal : {myDecimal}");

    myInt = (int)myDecimal;
    float myFloat = (float)myDecimal;
    // This line will throw an exception:
    //myInt = myDecimal;
    Console.WriteLine($"int : {myInt} float : {myFloat}");

    Console.WriteLine("Explicit Conversion");
    int num1 = 5;
    int num2 = 7;
    string message = num1.ToString() + num2.ToString();
    Console.WriteLine(message);

    string str1 = "5";
    string str2 = "7";
    int sum1 = int.Parse(str1) + int.Parse(str2);
    int sum2;
    // discard operator to ignore the bool return value
    _ = int.TryParse(str1, out int parsedValue1);
    _ = int.TryParse(str2, out int parsedValue2);
    sum2 = parsedValue1 + parsedValue2;
    int sum3 = Convert.ToInt32(str1) + Convert.ToInt32(str2);
    Console.WriteLine($"Parse : {sum1}");
    Console.WriteLine($"TryParse (prevents error) : {sum2}");
    Console.WriteLine($"Convert : {sum3}");

    Console.WriteLine("Usage of Convert");
    Console.WriteLine(1.5m.ToString());
    int truncat = (int)1.5m; // casting truncates
    Console.WriteLine(truncat);

    int rounds = Convert.ToInt32(1.5m); // converting rounds up
    Console.WriteLine(rounds);

    string parse = "bad";
    int result = 0;
    if (int.TryParse(parse, out result))
    {
      Console.WriteLine($"Measurement: {result}");
    }
    else
    {
      Console.WriteLine("Unable to report the measurement.");
    }
  }
}