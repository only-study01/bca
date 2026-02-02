class Parent{
    Parent(){
        System.out.println("Hello Parent");
    }
}

class Child extends Parent{
    Child(){
        System.out.println("Hello Child");
    }
}

public class Constructors_Inheritance {
    public static void main(String[] args) {
        Child obj = new Child();
    }
}
