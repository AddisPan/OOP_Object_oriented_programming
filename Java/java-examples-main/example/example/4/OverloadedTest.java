public class OverloadedTest{
   public static void print( Integer[] input ){
      for ( Integer element : input ){
         System.out.printf( "%s ", element );
   	  }
      System.out.println();
   } 
   public static void print( Double[] input ){
      for ( Double element : input ){
         System.out.printf( "%s ", element );
	  }
      System.out.println();
   } 
   public static void print( String[] input ){
      for ( String element : input ){
         System.out.printf( "%s ", element );
      }
      System.out.println();
   } 
   public static void print( Character[] input ){
      for ( Character element : input ){
         System.out.printf( "%s ", element );
      }
      System.out.println();
   } 
   public static void main( String args[] ){
      Integer[] integer1 = { 1, 2, 3, 4, 5, 6 };
      Double[] double1 = { 1.1, 2.1, 3.1, 4.1, 5.1, 6.1, 7.1 };
      String[] string1 = { "大", "家", "好", "Java2", "程式設計" };
      Character[] char1 = {'A','B','C','D','E'};
      System.out.println( "整數型態的陣列" );
      print( integer1 );
      System.out.println( "雙精度浮點數的陣列:" );
      print( double1 ); 
      System.out.println( "字串陣列:" );
      print( string1 ); 
      System.out.println("字元型態的陣列");
      print(char1);
   } 
} 