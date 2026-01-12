public class ImmutableStringExample {
    public static void main(String[] args) {
        ImmutableStringBuilder s = new ImmutableStringBuilder("1");

        for (int i = 2; i <= Math.pow(10, 6); i++) {
            s = s.concat(String.valueOf(i));
        }

        System.out.println(s.toString());
    }
}

class ImmutableStringBuilder {
    private final String value;

    public ImmutableStringBuilder(String value) {
        this.value = value;
    }

    public ImmutableStringBuilder concat(String str) {
        return new ImmutableStringBuilder(this.value + str);
    }

    @Override
    public String toString() {
        return this.value;
    }
}
