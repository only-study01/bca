public class jumping_statment {
    public static int sum(Integer a){
        if(a == null){
            return -1;
        }
        return a+a;
    }
    public static void main(String[] args) {
        for(int i = 0;i < 10;i++){
            if(i == 9){
                break;
            }
        }

        for(int i = 0;i < 10;i++){
            if(i == 5 || i == 8){
                continue;
            }
        }

        System.out.println(sum(10));
        System.out.println(sum(null));
    }
}
