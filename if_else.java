public class if_else {
    public static void main(String[] args) {
        int a = 10;
        int b = 20;
        int c = 30;
        if(a > b){
            System.out.println("A is big");
        }

        if(a > b){
            System.out.println("A is big");
        } else{
            System.out.println("b is big");
        }


        if(a > b){
            System.out.println("A is big");
        } else if(c > a){   
            System.out.println("C is big");
        } else{
            System.out.println("b is big");
        }

        if(a > b){
            if(a > c){
                System.out.println("A is big");
            } else{
                System.out.println("C is big");
            }
        } else{
            if(b > c){
                System.out.println("B is big");
            } else{
                System.out.println("C is big");
            }
        }

        
    }
}
