public partial class VariablesTypes
{
  public static void start()
  {
    int val_A = 2;
    int val_B = val_A;
    val_B = 5;

    Console.WriteLine("--Value Types--");
    Console.WriteLine($"val_A: {val_A}");
    Console.WriteLine($"val_B: {val_B}");
    int[] ref_A = new int[1];
    ref_A[0] = 2;
    int[] ref_B = ref_A;
    ref_B[0] = 5;

    Console.WriteLine("--Reference Types--");
    Console.WriteLine($"ref_A[0]: {ref_A[0]}");
    Console.WriteLine($"ref_B[0]: {ref_B[0]}");
  }
}