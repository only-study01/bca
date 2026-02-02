class Emp{
    public int id;
    public String name;

    void show(){
        System.out.println("id is : " + this.id + " name is : " + this.name);
    }
}

public class Shallow_Cloning {
    public static void main(String[] args) {
        Emp e1 = new Emp();
        e1.id = 12;
        e1.name = "bhavin";
        e1.show();

        Emp e2 = e1;
        e2.id = 21;
        e2.name = "vishal";
        e1.show();
        e2.show();
    }
}
