import java.util.concurrent.*;
import java.util.concurrent.locks.*;
public class WithoutSync3 {
  private Account account = new Account();
  private Thread[] thread = new Thread[50];
  public static void main(String[] args) {
    WithoutSync3 test = new WithoutSync3();
    System.out.println("存款金額 ? " +test.account.getBalance());
    WithoutSync3 test1 = new WithoutSync3();
    System.out.println("存款金額 ? " +test1.account.getBalance());
  }
  public WithoutSync3() {
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

    public synchronized void deposit(int amount) { 
      int newBalance = balance + amount;
      try {
        Thread.sleep(1);
      }
      catch (InterruptedException ex) {
      }finally {
      	balance = newBalance;
      }
	  

    }
  }
}