import java.util.Scanner;
public class MyExceptions{
   public static void main (String[] args) throws Error_Exception{
      final int MIN = 10, MAX = 55;
      Scanner scan = new Scanner (System.in);
      Error_Exception problem =
         new Error_Exception ("輸入的數字沒有在指定範圍內");
      System.out.print ("請輸入數自在" + MIN +"和" + MAX + "之間:");
      int value = scan.nextInt();
      if (value < MIN || value > MAX){
         throw problem;
      }
      System.out.println ("main()函數結束");
   }
}
