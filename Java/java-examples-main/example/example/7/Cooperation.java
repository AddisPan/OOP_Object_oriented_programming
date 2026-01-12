public class Cooperation {
  private Account account = new Account();
  private Thread t1 = new DepositThread();
  private Thread t2 = new WithdrawThread();
  public static void main(String[] args) {
    Cooperation test = new Cooperation();
    System.out.println("執行緒 1\t\t執行緒 2\t\t銀行帳戶");
  }
  public Cooperation() {
    t1.start();
    t2.start();
  }
  class DepositThread extends Thread {
    public void run() {
      while (true) {
        account.deposit((int)(Math.random() * 10) + 1);
        try { 
          Thread.sleep(100);
        }
        catch (InterruptedException ex) {
          ex.printStackTrace();
        }
      }
    }
  }
  class WithdrawThread extends Thread {
    public void run() {
      while (true) {
        account.withdraw((int)(Math.random() * 10) + 1);
      }
    }
  }
  class Account {
    private int balance = 0;
    public int getBalance() {
      return balance;
    }
    public synchronized void deposit(int amount) {
      balance += amount;
      System.out.println("存款 " + amount +"\t\t\t\t\t\t" + getBalance());
      this.notify();
    }
    public synchronized void withdraw(int amount) {
      try {
        while (balance < amount)
          this.wait();
      }
      catch (InterruptedException ex) {
        ex.printStackTrace();
      }
      balance = balance-amount;
      System.out.println("\t\t\t提款 " + amount +"\t\t\t" + getBalance());
    }
  }
}
