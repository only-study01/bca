public class private_constructor {
    int id;
    String name;
    
    private private_constructor(int id,String name){
        this.id = id;
        this.name = name;
    }

    void show(){
        System.out.println("id is : " + this.id  + "name is : " + this.name); 
    }

    public static void main(String[] args) {
        copy_constrouctor obj = new copy_constrouctor(12,"bhavin");
        obj.show();
    }
}
