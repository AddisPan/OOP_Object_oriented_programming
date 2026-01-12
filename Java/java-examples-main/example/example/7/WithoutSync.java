public class WithoutSync {
  private Account account = new Account();
  private Thread[] thread = new Thread[50];
  public static void main(String[] args) {
    WithoutSync test = new WithoutSync();
    System.out.println("存款金額 ? " +test.account.getBalance());
    WithoutSync test1 = new WithoutSync();
    System.out.println("存款金額 ? " +test1.account.getBalance());
  }
  public WithoutSync() {
    ThreadGroup g = new ThreadGroup("group");
    boolean done = false;
    for (int i = 0; i < 50; i++) {
      thread[i] = new Thread(g, new AddAPennyThread(), "t");
      thread[i].start();
    }
    while (!done)
      if (g.activeCount() == 0)
        done = true;
  }
  class AddAPennyThread extends Thread {
    public void run() {
      account.deposit(1);
    }
  }
  class Account {
    private int balance = 0;

    public int getBalance() {
      return balance;
    }

    public void deposit(int amount) {
      int newBalance = balance + amount;
      /*try {
        Thread.sleep(1);
      }
      catch (InterruptedException ex) {
      }*/
	  
      balance = newBalance;
    }
  }
}