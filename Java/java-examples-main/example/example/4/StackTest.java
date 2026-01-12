public class StackTest{
   private double[] doubleElements = { 1.11, 2.11, 3.11, 4.11, 5.11};
   private int[] integerElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
   private Stack< Double > doubleStack;
   private Stack< Integer > integerStack; 
   public void testStacks(){
      doubleStack = new Stack< Double >( 5 ); 
      integerStack = new Stack< Integer >( 10); 
      testPushDouble();  
      testPushInteger(); 
   } 
   public void testPushDouble(){
         System.out.println( "\n將元素放到雙精度浮點數的堆疊上" );
         for ( double element : doubleElements ){
            System.out.printf( "%.2f ", element );
            doubleStack.push( element ); 
         } 
   } 
   public void testPushInteger(){
         System.out.println( "\n將元素放到整數的堆疊上" );
         for ( int element : integerElements ){
            System.out.printf( "%d ", element );
            integerStack.push( element ); 
         }
		System.out.println( "\n" );
   }
    public static void main( String args[] ){
      StackTest application = new StackTest();
      application.testStacks();      
   } 
} 