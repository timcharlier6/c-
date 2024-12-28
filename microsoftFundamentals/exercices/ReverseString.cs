public partial class ReverseString
{
  public void Reverse(string s)
  {
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    Console.WriteLine(charArray);
  }
}