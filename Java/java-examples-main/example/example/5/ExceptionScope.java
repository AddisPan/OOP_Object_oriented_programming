public class ExceptionScope{
   public void level1(){
      System.out.println("Level 1 開始呼叫");
      try{
         level2();
      }catch (ArithmeticException problem){
         System.out.println ();
         System.out.println ("例外的訊息是: " +
                             problem.getMessage());
         System.out.println ();
         System.out.println ("The call stack trace:");
         problem.printStackTrace();
         System.out.println ();
      }

      System.out.println("Level 1 結束");
   }
   public void level2(){
      System.out.println("Level 2 開始");
      level3 ();
      System.out.println("Level 2 結束");
   }
   public void level3(){
      int x = 5, y = 0;
      System.out.println("Level 3 開始");
      int result = x / y;
      System.out.println("Level 3 結束");
   }
}
