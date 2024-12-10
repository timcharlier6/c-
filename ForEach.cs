public partial class ForEach {
  public int ForEachLoop(int[] numbers) {
    int sum = 0;
    foreach (int number in numbers) {
      sum += number;
    }
    return sum;
  }
}