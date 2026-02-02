import java.util.Scanner;;
public class UserInput {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter your name : ");
        String name = sc.nextLine();
        System.out.println("Name is " + name);
        
        System.out.print("Enter your age : ");
        int n = sc.nextInt();
        System.out.println("age is " + n);
        sc.close();
    }
}
