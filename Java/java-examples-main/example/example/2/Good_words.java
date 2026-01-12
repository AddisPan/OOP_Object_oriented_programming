public class Good_words{
	private String sentence;
	private static int count=0;
    public Good_words(String str){      
       sentence=str;
       count++;         
    }
    public String toString(){
    	return sentence;
    }
    public static int getcount(){
    	return count;
    }
}