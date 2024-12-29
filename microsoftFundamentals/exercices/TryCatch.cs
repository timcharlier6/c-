public partial class TryCatch
{
  public static void Ex1()
  {
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    try
    {
      Console.WriteLine(float1 / float2);
      Console.WriteLine(number1 / number2);
    }
    catch
    {
      Console.WriteLine("An exception has been caught");
    }
    Console.WriteLine("Exiting the program");
  }
  public static void Ex2()
  {
    try
    {
      Process1();
    }
    catch (Exception e)
    {
      Console.WriteLine($"Exception caught in Main: {e.Message}");
    }

    Console.WriteLine("Exit program");

    static void Process1()
    {
      try
      {
        WriteMessage();
      }
      catch (Exception e)
      {
        Console.WriteLine($"Exception caught in Process1: {e.Message}");
      }

    }

    static void WriteMessage()
    {
      double float1 = 3000.0;
      double float2 = 0.0;
      int number1 = 3000;
      int number2 = 0;

      Console.WriteLine(float1 / float2);
      Console.WriteLine(number1 / number2);
    }
  }
  public static void Ex3()
  {
    // inputValues is used to store numeric values entered by a user
    string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

    foreach (string inputValue in inputValues)
    {
      int numValue = 0;
      try
      {
        numValue = int.Parse(inputValue);
      }
      catch (FormatException)
      {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
      }
      catch (OverflowException)
      {
        Console.WriteLine("The number you entered is too large or too small.");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

  }
  public static void Ex4()
  {
    checked
    {
      try
      {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
      }
      catch (OverflowException ex)
      {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
      }
    }

    try
    {
      string? str = null;
      int length = str.Length;
      Console.WriteLine("String Length: " + length);
    }
    catch (NullReferenceException ex)
    {
      Console.WriteLine("Error: The reference is null. " + ex.Message);
    }

    try
    {
      int[] numbers = new int[5];
      numbers[5] = 10;
      Console.WriteLine("Number at index 5: " + numbers[5]);
    }
    catch (IndexOutOfRangeException ex)
    {
      Console.WriteLine("Error: Index out of range. " + ex.Message);
    }

    try
    {
      int num3 = 10;
      int num4 = 0;
      int result2 = num3 / num4;
      Console.WriteLine("Result: " + result2);
    }
    catch (DivideByZeroException ex)
    {
      Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
    }

    Console.WriteLine("Exiting program.");
  }
  public static void Ex5()
  {
    try
    {
      OperatingProcedure1();
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
      Console.WriteLine("Exiting application.");
    }

    static void OperatingProcedure1()
    {
      string[][] userEnteredValues = new string[][]
      {
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
      };

      foreach (string[] userEntries in userEnteredValues)
      {
        try
        {
          BusinessProcess1(userEntries);
        }
        catch (Exception ex)
        {
          if (ex.StackTrace.Contains("BusinessProcess1"))
          {
            if (ex is FormatException)
            {
              Console.WriteLine(ex.Message);
              Console.WriteLine("Corrective action taken in OperatingProcedure1");
            }
            else if (ex is DivideByZeroException)
            {
              Console.WriteLine(ex.Message);
              Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

              // re-throw the original exception
              throw;
            }
            else
            {
              // create a new exception object that wraps the original exception
              throw new ApplicationException("An error occurred - ", ex);
            }
          }
        }

      }
    }

    static void BusinessProcess1(string[] userEntries)
    {
      int valueEntered;

      foreach (string userValue in userEntries)
      {
        try
        {
          valueEntered = int.Parse(userValue);

          checked
          {
            int calculatedValue = 4 / valueEntered;
          }
        }
        catch (FormatException)
        {
          FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
          throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
          DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
          throw unexpectedDivideByZeroException;

        }
      }
    }
  }
  public static void Ex6()
  {
    // Prompt the user for the lower and upper bounds
    Console.Write("Enter the lower bound: ");
    int lowerBound = int.Parse(Console.ReadLine());

    Console.Write("Enter the upper bound: ");
    int upperBound = int.Parse(Console.ReadLine());

    decimal averageValue = 0;
    bool exit = false;

    do
    {
      try
      {
        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the value returned by AverageOfEvenNumbers in the console
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");
        exit = true;

      }
      catch (ArgumentOutOfRangeException ex)
      {
        Console.WriteLine("An error has occurred.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
        string? userResponse = Console.ReadLine();
        if (userResponse.ToLower().Contains("exit"))
        {
          exit = true;
        }
        else
        {
          upperBound = int.Parse(userResponse);
          exit = false;
        }
      }
    } while (exit == false);
    // Wait for user input
    //Console.ReadLine();


    static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
    {

      if (lowerBound >= upperBound)
      {
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
      }
      int sum = 0;
      int count = 0;
      decimal average = 0;

      for (int i = lowerBound; i <= upperBound; i++)
      {
        if (i % 2 == 0)
        {
          sum += i;
          count++;
        }
      }

      average = (decimal)sum / count;

      return average;
    }
  }
  public static void Ex7()
  {
    string[][] userEnteredValues = new string[][]
    {
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
    };

    try
    {
      Workflow1(userEnteredValues);
      Console.WriteLine("'Workflow1' completed successfully.");

    }
    catch (DivideByZeroException ex)
    {
      Console.WriteLine("An error occurred during 'Workflow1'.");
      Console.WriteLine(ex.Message);
    }

    static void Workflow1(string[][] userEnteredValues)
    {
      foreach (string[] userEntries in userEnteredValues)
      {
        try
        {
          Process1(userEntries);
          Console.WriteLine("'Process1' completed successfully.");
          Console.WriteLine();
        }
        catch (FormatException ex)
        {
          Console.WriteLine("'Process1' encountered an issue, process aborted.");
          Console.WriteLine(ex.Message);
          Console.WriteLine();
        }
      }
    }

    static void Process1(String[] userEntries)
    {
      int valueEntered;

      foreach (string userValue in userEntries)
      {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
          if (valueEntered != 0)
          {
            checked
            {
              int calculatedValue = 4 / valueEntered;
            }
          }
          else
          {
            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
          }
        }
        else
        {
          throw new FormatException("Invalid data. User input values must be valid integers.");
        }
      }
    }
  }
}
