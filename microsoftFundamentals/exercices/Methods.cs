using System.Security.Cryptography.X509Certificates;

public partial class Methods
{

  public static void Ex1()
  {
    int[] times = { 800, 1200, 1600, 2000 };
    int diff = 0;

    Console.WriteLine("Enter current GMT");
    int currentGMT = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Current Medicine Schedule:");
    DisplayTimes();

    Console.WriteLine("Enter new GMT");
    int newGMT = Convert.ToInt32(Console.ReadLine());

    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
      Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
      diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
      AdjustTimes();
    }
    else
    {
      diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
      AdjustTimes();
    }

    Console.WriteLine("New Medicine Schedule:");
    DisplayTimes();

    void DisplayTimes()
    {
      /* Format and display medicine times */
      foreach (int val in times)
      {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
          time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
          time = time.Insert(0, "0:");
        }
        else
        {
          time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
      }
      Console.WriteLine();
    }

    void AdjustTimes()
    {
      /* Adjust the times by adding the difference, keeping the value within 24 hours */
      for (int i = 0; i < times.Length; i++)
      {
        times[i] = ((times[i] + diff)) % 2400;
      }
    }
  }
  public static void Ex2()
  {
    string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
    string[] address;
    bool validLength = false;
    bool validZeroes = false;
    bool validRange = false;

    foreach (string ip in ipv4Input)
    {
      // Split the IP address into an array of strings
      // StringSplitOptions.RemoveEmptyEntries omits empty entries from the address array and prevent attempts to parse empty strings
      address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

      ValidateLength();
      ValidateZeroes();
      ValidateRange();

      if (validLength && validZeroes && validRange)
      {
        Console.WriteLine($"{ip} is a valid IPv4 address");
      }
      else
      {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
      }
    }

    void ValidateLength()
    {
      validLength = address.Length == 4;
    };

    void ValidateZeroes()
    {
      foreach (string number in address)
      {
        if (number.Length > 1 && number.StartsWith("0"))
        {
          validZeroes = false;
          return;
        }
      }

      validZeroes = true;
    }

    void ValidateRange()
    {
      foreach (string number in address)
      {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
          validRange = false;
          return;
        }
      }
      validRange = true;
    }
  }

  public static void Ex3()
  {

    do
    {
      Console.WriteLine("Enter radius");
      string? input = Console.ReadLine();
      if (int.TryParse(input, out int radius))
      {
        PrintCircleArea(radius);
        PrintCircleCircumference(radius);
      }
      else
      {
        Console.WriteLine("Invalid input");
      }
    } while (true);

    void PrintCircleArea(int radius)
    {
      double pi = 3.14159;
      double area = pi * (radius * radius);
      Console.WriteLine($"Area = {area}");
    }
    void PrintCircleCircumference(int radius)
    {
      double pi = 3.14159;
      double circumference = 2 * pi * radius;
      Console.WriteLine($"Circumference = {circumference}");
    }
  }

  public static void Ex4()
  {
    Console.WriteLine("By Value: ");
    ByValue();
    Console.WriteLine();
    Console.WriteLine("By Reference (mutable): ");
    ByReference();
    Console.WriteLine();
    Console.WriteLine("By Reference (immutable): ");
    // immutable means that the value can't be altered, but it can be reassigned.
    Immutable();
    Console.WriteLine();

    void ByValue()
    {

      int a = 3;
      int b = 4;
      int c = 0;

      Multiply(a, b, c);
      Console.WriteLine($"global statement: {a} x {b} = {c}");

      void Multiply(int a, int b, int c)
      {
        c = a * b;
        Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
      }
    }

    void ByReference()
    {
      int[] array = { 1, 2, 3, 4, 5 };

      PrintArray(array);
      ClearEven(array);
      PrintArray(array);

      void PrintArray(int[] array)
      {
        foreach (int a in array)
        {
          Console.Write($"{a} ");
        }
        Console.WriteLine();
      }

      void ClearEven(int[] array)
      {
        for (int i = 0; i < array.Length; i++)
        {
          if (array[i] % 2 == 0)
            array[i] = 0;
        }
      }


    }

    void Immutable()
    {
      Console.WriteLine("--scope");
      scope();
      Console.WriteLine("--global");
      global();
      void scope()
      {
        string status = "Healthy";

        Console.WriteLine($"Start: {status}");
        SetHealth(status, false);
        Console.WriteLine($"End: {status}");

        void SetHealth(string status, bool isHealthy)
        {
          status = (isHealthy ? "Healthy" : "Unhealthy");
          Console.WriteLine($"Middle: {status}");
        }

      }
      void global()
      {
        string status = "Healthy";

        Console.WriteLine($"Start: {status}");
        SetHealth(false);
        Console.WriteLine($"End: {status}");

        void SetHealth(bool isHealthy)
        {
          status = (isHealthy ? "Healthy" : "Unhealthy");
          Console.WriteLine($"Middle: {status}");
        }
      }

    }
  }
  public static void Ex5()
  {
    Console.WriteLine("Named Arguments:");
    namedArguments();
    void namedArguments()
    {
      string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
      string[] rsvps = new string[10];
      int count = 0;
      RSVP("Rebecca");
      RSVP("Nadia", 2, "Nuts");
      RSVP(name: "Linh", partySize: 2, inviteOnly: false);
      RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
      RSVP("Noor", 4, inviteOnly: false);
      RSVP("Jonte", 2, "Stone fruit", false);
      ShowRSVPs();

      void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
      {
        if (inviteOnly)
        {
          bool found = false;
          foreach (string guest in guestList)
          {
            if (guest.Equals(name))
            {
              found = true;
              break;
            }
          }
          if (!found)
          {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
          }
        }

        rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
        count++;
      }

      void ShowRSVPs()
      {
        Console.WriteLine("\nTotal RSVPs:");
        for (int i = 0; i < count; i++)
        {
          Console.WriteLine(rsvps[i]);
        }
      }
    }
  }
  public static void Ex6()
  {
    string[,] corporate =
  {
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
  };

    string[,] external =
    {
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

    string internalDomain = "contoso.com";
    string externalDomain = "hayworth.com";

    for (int i = 0; i < corporate.GetLength(0); i++)
    {
      // display internal email addresses
      displayEmail(firstName: corporate[i, 0], lastName:corporate[i, 1]);
    }

    for (int i = 0; i < external.GetLength(0); i++)
    {
      // display external email addresses
      displayEmail(firstName: external[i, 0], lastName: external[i, 1], isInternal: false);
    }
    void displayEmail(string firstName, string lastName, bool isInternal = true)
    {
      string email = $"{firstName.Substring(0, 2)}{lastName}@{(isInternal ? internalDomain : externalDomain)}".ToLower();
      Console.WriteLine(email);
    }

  }
}