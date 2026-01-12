import java.util.Random;
import java.io.*;
public class IO{
   public static void main (String[] args) throws IOException{
      final int MAX = 9;
      int value;
      String file = "test.txt";
      Random rand = new Random();
      FileWriter fw = new FileWriter (file);
      BufferedWriter bw = new BufferedWriter (fw);
      PrintWriter outFile = new PrintWriter (bw);
      for (int line=1; line <= MAX; line++){
         for (int num=1; num <= MAX; num++){
            value = rand.nextInt (9);
            outFile.print (value );
         }
         outFile.println ();
      }
      outFile.close();
      System.out.println ("輸出檔案成功被建立" + file);
   }
}
