public class assert_strictfp_enum {
    public strictfp static double sum(double a, double b) {
        return a + b;
    }

    enum Day {
        MON, TUE, WED, THU, FRI, SAT, SUN
    }


    public static void main(String[] args) {
        System.out.println(sum(10e+10, 6e+08));

        int i = 14;
        assert i >= 12 : "i is not 12"; 
        System.out.println(i);

        System.out.println(Day.FRI);
    }
}
