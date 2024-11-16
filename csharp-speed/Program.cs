using System.Diagnostics;

class Program
{
  static void Main()
  {
    Stopwatch stopwatch = new();

    stopwatch.Start();

    int input = 2000000;
    for (int i = 1; i <= input; i++)
    {
        Console.WriteLine(i);
    }

    stopwatch.Stop();

    double resultTime = stopwatch.Elapsed.TotalSeconds;

    Console.WriteLine($"Result Time: {resultTime} detik");
  }
}
