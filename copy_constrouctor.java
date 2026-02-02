public class copy_constrouctor {
    int id;
    String name;
    
    copy_constrouctor(int id,String name){
        this.id = id;
        this.name = name;
    }

    copy_constrouctor(copy_constrouctor c){
        this.id = c.id;
        this.name = c.name;
    }

    void show(){
        System.out.println("id is : " + this.id  + "name is : " + this.name); 
    }

    public static void main(String[] args) {
        copy_constrouctor obj = new copy_constrouctor(12,"bhavin");
        obj.show();
    }
}
