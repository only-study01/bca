public class Varargs {
    public static int sum(int... n){
        int total = 0;
        for(int i : n){
            total += i;
        }

        return total;
    }
    public static void main(String[] args) {
        int result = sum(1,2,3,4,5);
        System.out.println(result);
    }
}