import java.util.concurrent.locks.*;
public class SynchTest
{  
   public static final int NAC = 10;
   public static final double INI_BALANCE = 100;
   public static void main(String[] args)
   {  
      Bank b = new Bank(NAC,INI_BALANCE);
      int i;
      for (i = 0; i < NAC; i++)
      {  
         TransferRun r = new TransferRun(b, i, INI_BALANCE);
         Thread t = new Thread(r);
         t.start();
      }
   }
}
class Bank
{ 
   private final double[] accounts;
   private ReentrantLock bankLock;
   private Condition sufficientFunds;
   public Bank(int n, double initialBalance)
   {  
      accounts = new double[n];
      for (int i = 0; i < accounts.length; i++)
         accounts[i] = initialBalance;
      bankLock = new ReentrantLock();
      sufficientFunds = bankLock.newCondition();
   }
   public void move(int from,int to,double amount) throws InterruptedException
   {  
      bankLock.lock();
      try
      {
         while (accounts[from] < amount)
            sufficientFunds.await();
         System.out.print(Thread.currentThread());      
         accounts[from] -= amount;
         System.out.printf(" %10.2f 從帳戶 %d 到 %d", amount, from, to);
         accounts[to] += amount;
         System.out.printf(" 銀行帳戶總金額: %10.2f%n", getTotalBalance());
         sufficientFunds.signalAll();
      }
      finally
      {
         bankLock.unlock();
      }
   }
   public double getTotalBalance()
   {  
      bankLock.lock();
      try
      {      
         double sum = 0;

         for (double a : accounts)
            sum += a;

         return sum;
      }
      finally
      {
         bankLock.unlock();
      }
   }
   public int size()
   {
      return accounts.length;
   }
}
class TransferRun implements Runnable
{  
   private Bank bank;
   private int fromAccount;
   private double maxAmount;
   private int repetitions;
   private int DELAY = 100000;
   public TransferRun(Bank b, int from, double max)
   {  
      bank = b;
      fromAccount = from;
      maxAmount = max;
   }
   public void run()
   {  
      try
      {  
         while (true)
         {  
            int toAccount = (int) (bank.size() * Math.random());
            double amount = maxAmount * Math.random();
            bank.move(fromAccount, toAccount, amount);
            Thread.sleep((int) (DELAY * Math.random()));
         }
      }
      catch (InterruptedException e) {}
   }
}
