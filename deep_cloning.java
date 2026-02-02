class Emp{
    public int id;
    public String name;

    void show(){
        System.out.println("id is : " + this.id + " name is : " + this.name);
    }
}

public class deep_cloning {
    public static void main(String[] args) {
        Emp e1 = new Emp();
        e1.id = 12;
        e1.name = "bhavin";
        e1.show();

        Emp e2 = new Emp();
        e2.id = e1.id;
        e2.name = e1.name;
        e1.show();
        e2.show();
    }
}

