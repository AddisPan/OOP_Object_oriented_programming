public class Test{
	public static void main(String[] arg){
		KeyValueTable<String, Integer> grades=
		             new  KeyValueTable<String, Integer>();
		grades.add("§d¨Î¿Î",new Integer(99));
		grades.add("¾G§JÄ«",new Integer(98));
		System.out.println("¬d¸ß§d¨Î¿Îªº¦¨ÁZ");
		Integer wuGrade=grades.lookUp("§d¨Î¿Î");
		System.out.println(wuGrade);
	}
}

