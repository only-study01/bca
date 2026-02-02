// package oop;

class Car{
    private String name;
    private String color;

    void car(){
        System.out.println("car name is : " + name + "car color is : " + color);
    }

    String getData(){
        return name;
    }

    void setData(String name,String color){
        this.color = color;
        this.name = name;
    }
}

//  inheritanse
class Toyota extends Car{
    int speed;

    void speed(){
        System.out.println(getData() + "speed is : " + speed);
    }
}

public class Encapsulation_Inheritance {
    public static void main(String[] args) {
        Toyota fortuner = new Toyota();
        // fortuner.name = "Fortuner";
        // fortuner.color = "Black";
        fortuner.setData("Fortuner", "Black");
        fortuner.speed = 200;

        fortuner.car();
        fortuner.speed();
    }
}
