public class Test2{
	public static void main(String[] arg){
		KeyValueTable<String, Character> grades=
		             new  KeyValueTable<String, Character>();
		grades.add("§d¨Î¿Î",new Character('A'));
		grades.add("¾G§JÄ«",new Character('B'));
		System.out.println("¬d¸ß§d¨Î¿Îªº¦¨ÁZ");
		Character wuGrade=grades.lookUp("§d¨Î¿Î");
		System.out.println(wuGrade);
	}
}

