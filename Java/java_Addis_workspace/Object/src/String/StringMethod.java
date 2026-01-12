package String;

public class StringMethod{
	public static void main(String[] args){
		String sentence = "I am a good student";
		String ChineseWords = "中文字";
		String sentence1, sentence2, sentence3, sentence4, sentence5;
		System.out.println("原始字串:"+sentence);
		System.out.println("字串長度:"+sentence.length());
		System.out.println("中文字的字串長度:"+ChineseWords.length());
		sentence1=sentence.toLowerCase();
		sentence2=sentence.substring(5,10);
		sentence3=sentence.concat("大家好");
		sentence4=sentence.replace('a', 'b');
		sentence5=sentence.toUpperCase();
		System.out.println("sentence1:"+sentence1);
		System.out.println("sentence2:"+sentence2);
		System.out.println("sentence3:"+sentence3);
		System.out.println("sentence4:"+sentence4);
		System.out.println("sentence5:"+sentence5);
	}
}