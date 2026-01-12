public class Stack< G >{
   private final int size; 
   private int top; 
   private G[] elements; 
   public Stack(){
      this( 10 ); 
   } 
   public Stack( int s ){
      if(s>0 ){
      	size=s;
      }else{
      	size=10;
      }
      top = -1; 
      elements = ( G[] ) new Object[ size ]; 
   } 
   public void push( G pushValue ){
      elements[ ++top ] = pushValue; 
   }
} 
