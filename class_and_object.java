// package oop;

class Tmp{
    int a = 10;
    int b = 30;
    void sum(){
        System.out.println("Sum is : " +(a+b));
    }    
}

public class class_and_object {
    public static void main(String[] args) {
        Tmp t = new Tmp();
        t.a = 30;
        t.b = 40;
        t.sum();
    }
}