package Init;

class Point{
	static int npoints;
	int x, y;
	double z;
	char ch;
	boolean bb;
	Point root;
}
class TestInit{
	public static void main(String[] args){
		System.out.println("npoints=" + Point.npoints);
		Point po=new Point();
		System.out.println("po.x=" + po.x + ", po.y=" + po.y + " ,po.z" + po.z);
		System.out.println("¦r¤¸ch=" + po.ch);
		System.out.println("¥¬ªLbb=" + po.bb);
		System.out.println("po.root=" + po.root);
	}
}