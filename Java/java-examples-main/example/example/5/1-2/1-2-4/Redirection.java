import java.io.PrintStream;
import java.io.FileOutputStream;
import java.io.FileNotFoundException;
public class Redirection{
   public static void main(String[] args){
      PrintStream errorStream = null;
      try{
          errorStream =  new PrintStream(
                          new FileOutputStream("error.txt"));
      }catch(FileNotFoundException e){
         System.out.println("無法使用FileOutputStream打開檔案");
      }
      System.setErr(errorStream);
      System.out.println("System.out的Hello");
      System.err.println("System.err的Hello");      
      errorStream.close( );
   }
}



