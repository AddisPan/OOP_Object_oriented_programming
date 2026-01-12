package Compare;

public class FoodLp{
	public static void main(String[] args) {
		String meal = "便當";
		int money = 5;
		if ((meal == "便當" || meal == "麥當勞") && money >= 100) {
			System.out.println("可以外賣foodpoonda");
		}else {
			System.out.println("不可以外賣");
		}
	}
}