class Point {
	int x, y, useCount;
	Point(int x, int y) { this.x = x; this.y = y; }
	final static Point origin = new Point(0, 0);
}
class Test_Static {
	public static void main(String[] args) {
		Point p = new Point(3,3);
		Point q = new Point(2,2);
		p.x = 5; p.y = 5; p.useCount++; p.origin.useCount++;
		System.out.println("(" + q.x + "," + q.y + ")");
		System.out.println(q.useCount);
		System.out.println(q.origin == Point.origin);
		System.out.println(q.origin.useCount);
	}
}

