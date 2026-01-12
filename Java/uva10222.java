import java.util.*;
 
public class uva10222{
  public static void main(String[] args) {
    Scanner sc=new Scanner(System.in);
    String decode = "qwertyuiop[]asdfghjkl;'zxcvbnm,./";
    while(sc.hasNextLine())
    {
    	String str = sc.nextLine().toLowerCase();
    	for(int i = 0; i < str.length(); i++)
    	{
    		char c = str.charAt(i);
    		int index = decode.indexOf(c) - 2;
    		if(c == ' ')
    			System.out.print(" ");
    		else
    			System.out.print(decode.charAt(index));
    	}
    	System.out.println();
    }
  }
}