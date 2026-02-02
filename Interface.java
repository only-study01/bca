interface InterfaceEmp {
   public void show();
}

class Emp implements InterfaceEmp {
    public void show(){
        System.out.println("Hello Emp");
    }
}
public class Interface {
    public static void main(String[] args) {
        Emp obj = new Emp();
        obj.show();
    }
}
