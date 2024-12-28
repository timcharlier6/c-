public partial class FormatAlphanumeric
{
  public static void Basics()
  {
    string hello = "Hello";
    string world = "World";

    Console.WriteLine("Composite Formatting:");

    string result1 = string.Format("{0} {1}!", hello, world);
    string result2 = string.Format("{1} {1}!", hello, world);
    string result3 = string.Format("{0} {0} {1}!", hello, world);
    Console.WriteLine(result1);
    Console.WriteLine(result2);
    Console.WriteLine(result3);

    Console.WriteLine("");
    Console.WriteLine("String Interpolation:");

    Console.WriteLine($"{hello} {world}!");
    Console.WriteLine($"{world} {hello}!");
    Console.WriteLine($"{hello} {hello} {hello}!");

    Console.WriteLine("");
    Console.WriteLine("Number Formatting:");

    decimal price = 123.45m;
    int discount = 50;
    Console.WriteLine($"Price: {price:C} (Save {discount:C})");

    decimal measurement = 123456.78912m;
    Console.WriteLine($"Measurement: {measurement:N} units");
    Console.WriteLine($"Measurement: {measurement:N4} units");

    decimal tax = .36785m;
    Console.WriteLine($"Tax rate: {tax:P2}");

    decimal regularPrice = 67.55m;
    decimal salePrice = 59.99m;
    string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (regularPrice - salePrice), regularPrice);
    yourDiscount += $"A discount of {((regularPrice - salePrice) / regularPrice):P2}!";
    Console.WriteLine(yourDiscount);

    Console.WriteLine("");
    Console.WriteLine("Mix it up:");

    int invoiceNumber = 1201;
    decimal productShares = 25.4568m;
    decimal subtotal = 2750.00m;
    decimal taxPercentage = .15825m;
    decimal total = 3185.19m;
    Console.WriteLine($"Invoice Number: {invoiceNumber}");
    Console.WriteLine($"   Shares: {productShares:N3} Product");
    Console.WriteLine($"     Sub Total: {subtotal:C}");
    Console.WriteLine($"           Tax: {taxPercentage:P2}");
    Console.WriteLine($"     Total Billed: {total:C}");

    Console.WriteLine("");
    Console.WriteLine("Padding and alignment:");

    string input = "0123456789A";
    Console.WriteLine(input.PadLeft(12));
    Console.WriteLine(input.PadRight(12));
    Console.WriteLine(input.PadLeft(12, '-'));
    Console.WriteLine(input.PadRight(12, '-'));


    Console.WriteLine("");

    string paymentId = "769C";
    string payeeName = "Mr. Stephen Ortega";
    string paymentAmount = "$5,000.00";

    var formattedLine = paymentId.PadRight(6);
    formattedLine += payeeName.PadRight(24);
    formattedLine += paymentAmount.PadLeft(10);

    Console.WriteLine("1234567890123456789012345678901234567890");
    Console.WriteLine(formattedLine);

  }

  public static void StringFormattingChallenge()
  {
    string customerName = "Ms. Barros";

    string currentProduct = "Magic Yield";
    int currentShares = 2975000;
    decimal currentReturn = 0.1275m;
    decimal currentProfit = 55000000.0m;

    string newProduct = "Glorious Future";
    decimal newReturn = 0.13125m;
    decimal newProfit = 63000000.0m;

    Console.WriteLine($"Dear {customerName},");
    Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
    Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
    Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

    Console.WriteLine("Here's a quick comparison:\n");

    string comparisonMessage = "";

    comparisonMessage = currentProduct.PadRight(20);
    comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
    comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

    comparisonMessage += "\n";
    comparisonMessage += newProduct.PadRight(20);
    comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
    comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

    Console.WriteLine(comparisonMessage);
  }
}