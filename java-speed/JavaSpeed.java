public class JavaSpeed {
  public static void main(String[] args) {
    long startTime = System.nanoTime();

    int input = 2000000;

    for (int i = 1; i <= input; i++) {
      System.out.println(i);
    }

    long endTime = System.nanoTime();
    long resultTime = endTime - startTime;

    System.out.printf("ResultTime: %f s", resultTime / 1_000_000_000.0);
  }
}
