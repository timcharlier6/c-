public partial class ForEach {
  public static void ForEachLoop(int[] numbers) {
    int sum = 0;
    foreach (int number in numbers) {
      sum += number;
    }
    Console.WriteLine(sum);
  }
}