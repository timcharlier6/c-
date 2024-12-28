public partial class BoolCheck
{
  public static void hasPermission()
  {
    string permission;
    do { 
      Console.WriteLine("Enter your permission level (Admin|Manager|User): ");
      permission = Console.ReadLine();
    } while (permission != "Admin" && permission != "Manager" && permission != "User");

    if (permission.Contains("Admin"))
    {
        Console.WriteLine("Welcome, Admin user.");
    }
    else if (permission.Contains("Manager"))
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
      Console.WriteLine("You do not have sufficient privileges.");
    }
  }
}