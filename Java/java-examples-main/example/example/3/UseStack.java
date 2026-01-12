import java.util.*;
public class UseStack
{
   public static void main (String[] args){  
      Scanner scan = new Scanner (System.in);
      Stack info_stack = new Stack();
      String info;
      int index = 0;
      System.out.println ("請輸入字串:");
      info = scan.nextLine();
      System.out.println ("反轉的字串:");
      while (index < info.length())
      {
         while (index < info.length() && info.charAt(index) != ' ')
         {
            info_stack.push (new Character(info.charAt(index)));
            index++;
         }
         while (!info_stack.empty())
            System.out.print (((Character)info_stack.pop()).charValue());
         System.out.print (" ");
         index++;
      }
      System.out.println();
   }
}
