package Gcd;

public class Gcd{
	public static void main(String[] args){
		System.out.println(gcd(21,15));
	}
	public static int gcd(int m, int n) {
		int ans;
//		if(m<n){
//			n=m;
//			ans = gcd(m,n);
//		}
		if(m%n==0){
			ans=n;
		}else{
			ans=gcd(m, m%n);
		}
		return ans;
	}
}