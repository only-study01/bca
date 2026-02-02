class demo {
    protected int a = 10;

    demo() {
        System.out.println("demo class constructor");
    }
}

public class protected_access extends demo {
    public static void main(String[] args) {

        protected_access obj = new protected_access();
        System.out.println("a is : " + obj.a);
    }
}



// ✔ Same class
// ✔ Same package
// ✔ Subclass
// ❌ Non-subclass in different package