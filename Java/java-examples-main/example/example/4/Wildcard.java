import java.util.ArrayList;
public class Wildcard{
   public static double sum( ArrayList< ? extends Number > list ){
      double total = 0; 
      for ( Number element : list ){
         total += element.doubleValue();
      }
      return total;
   } 
   public static void main( String args[] ){
      Integer[] integers = { 2, 4, 6, 8, 10 };
      ArrayList< Integer > integerList = new ArrayList< Integer >();
      for ( Integer element : integers ){
         integerList.add( element );
      }
      System.out.printf( "俱计﹃: %s\n", integerList );
      System.out.printf("俱计﹃い┮Τじ: %.0f\n\n",sum( integerList ));
      Double[] doubles = { 1.1, 2.1, 3.1 };
      ArrayList< Double > doubleList = new ArrayList< Double >();
      for ( Double element : doubles ){
         doubleList.add( element );
      }
      System.out.printf( "蛮弘疊翴计: %s\n", doubleList );
      System.out.printf("蛮弘疊翴计﹃い┮Τじ: %.1f\n\n",
                                                   sum( doubleList ) );
      Number[] numbers = { 1.1, 2, 3.1, 4,5.1 }; 
      ArrayList< Number > numberList = new ArrayList< Number >();
      for ( Number element : numbers ){
         numberList.add( element );
      }
      System.out.printf( "计﹃: %s\n", numberList );
      System.out.printf( "计﹃い┮Τじ: %.1f\n", 
         sum( numberList ) );
   } 
} 

