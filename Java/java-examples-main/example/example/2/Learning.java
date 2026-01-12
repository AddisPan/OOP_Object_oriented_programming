public class Learning{
	public static void main(String[] args){
		ArrayList friends=new ArrayList();
		friends.add("³¯¬î¥c");
		friends.add("³¯¬Ó¦t");
		friends.add("´ö¤å¬F");
		friends.add("´^´f§g");
		friends.add("¯»¶ê");
		System.out.println(friends);
		int index=friends.indexOf("¯»¶ê");		
		friends.remove(index);
		System.out.println(friends);
		System.out.println("¯Á¤Þ0ªºªB¤Í"+friends.get(0));
		System.out.println("·s¼WªB¤Íªü»õ");
		friends.add(4,"ªü»õ");
		System.out.println(friends);
	}
}