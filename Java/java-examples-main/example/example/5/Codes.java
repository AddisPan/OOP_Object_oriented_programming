import java.util.Scanner;
public class Codes{
   public static void main (String[] args){
      String code;
      char zone;
      int number, valid = 0, banned = 0;
      Scanner scan = new Scanner (System.in);
      System.out.print ("請輸入產品編號七位數(輸入quit來離開): ");
      code = scan.nextLine();
      while (!code.equals ("quit")){
         try{
            zone = code.charAt(6);
            number = Integer.parseInt(code.substring(0, 7));
            valid++;
         }
         catch (StringIndexOutOfBoundsException exception){
            System.out.println ("沒有輸入七位數: " + code);
         }catch (NumberFormatException exception){
            System.out.println ("編號不是數字: " + code);
         }
         System.out.print ("請輸入產品編號七位數(輸入quit來離開): ");
         code = scan.nextLine();
      }
      System.out.println ("正確的輸入編號: " + valid+"次");
   }
}
