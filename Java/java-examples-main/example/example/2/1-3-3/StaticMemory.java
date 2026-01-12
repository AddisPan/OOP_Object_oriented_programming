public class  StaticMemory{
		public static int x=1;
		private int u=4;
		protected void fun(int z){
			int y;
			y=50+z;
			System.out.println("Memory函數的區域變數y="+y);	
		}
		public static void main(String[] args){
	 		StaticMemory b1=new StaticMemory();
	 		StaticMemory b2=new StaticMemory();
	 		System.out.println("Memory成員資料="+b1.x);
			b1.x=b1.x+1;
			b2.x=b2.x+1;
			System.out.println("Memory成員資料="+b1.x);
			System.out.println("Memory成員資料="+b1.u);
			b1.u=b1.u+1;
			b2.u=b2.u+1;
			System.out.println("Memory成員資料="+b1.u);
	}	
}

