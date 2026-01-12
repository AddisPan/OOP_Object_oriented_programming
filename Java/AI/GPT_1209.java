public class GPT_1209 {
    public static void main(String[] args) {
        StringBuilder s = new StringBuilder("1");

        for (int i = 1; i <= Math.pow(10, 6); i++) {
            s.append(i);
        }

        String result = s.toString();
        System.out.println(result);
    }
}
