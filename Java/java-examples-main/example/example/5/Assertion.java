public class Assertion{
  public static void main(String[] args) {
    int i; int sum = 0;
    for (i = 0; i < 5; i++) {
      sum += i; 
    }
    assert i == 5;
    assert sum<0: sum;
  }
}