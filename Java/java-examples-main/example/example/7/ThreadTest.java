public class ThreadTest {
  public static void main(String[] args) {
    PChar t = new PChar('t', 50);
    PChar r = new PChar('r', 50);
    PNum  print50 = new PNum(50);
    t.start();
    r.start();
    print50.start();
  }
}
class PChar extends Thread {
  private char ch;  
  private int num;  

  public PChar(char i, int j) {
    ch = i;
    num = j;
  }
  public void run() {
    for (int k = 0; k < num; k++)
      System.out.print(ch);
  }
}
class PNum extends Thread {
  private int lastNum;
  public PNum(int n) {
    lastNum = n;
  }

  public void run() {
    for (int i = 1; i <= lastNum; i++)
      System.out.print(" " + i);
  }
}

