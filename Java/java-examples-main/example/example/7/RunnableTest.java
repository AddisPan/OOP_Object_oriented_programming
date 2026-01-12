public class RunnableTest {
  Thread t = new Thread(new Pchar('t', 50));
  Thread r = new Thread(new Pchar('r', 50));
  Thread print50 = new Thread(new PNum(50));
  public static void main(String[] args) {
    new RunnableTest();
  }
  public RunnableTest(){
    print50.start();
    t.start();
    r.start();
  }
  class Pchar implements Runnable {
    private char ch;  
    private int num;  
    public Pchar(char i, int j) {
      ch = i;
      num = j;
    }
    public void run() {
      for (int i = 0; i < num; i++)
        System.out.print(ch);
    }
  }
  class PNum implements Runnable {
    private int lastNum;
    public PNum(int n) {
      lastNum = n;
    }
    public void run() {
      for (int i = 1; i <= lastNum; i++)
        System.out.print(" " + i);
    }
  }
}
