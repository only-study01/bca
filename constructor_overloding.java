public class constructor_overloding {
    int id;
    String name;

    constructor_overloding(){
        System.out.println("roll number : " + "-" + " name is :  " + "-");
    }

    constructor_overloding(int a){
        id = a;
        System.out.println("roll number : " + this.id + " name is :  " + "-");
    }

    constructor_overloding(int a,String b){
        id = a;
        name = b;
        System.out.println("roll number : " + this.id + " name is :  " + this.name);
    }


    public static void main(String[] args) {
        constructor_overloding obj1 = new constructor_overloding();
        constructor_overloding obj2 = new constructor_overloding(1);
        constructor_overloding obj3 = new constructor_overloding(2,"bhavin");
    }
}
