public class default_access {

    int x = 20; // default access

    void display() {
        System.out.println("x is : " + x);
    }

    public static void main(String[] args) {
        default_access obj = new default_access();
        System.out.println("x is : " + obj.x);
        obj.display();
    }

}