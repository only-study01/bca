public class private_access {
    //  ✔ Same class
    // ❌ Same package
    // ❌ Subclass
    // ❌ Different package

    // Used for data hiding / encapsulation 🔒
    private int x = 10;

    private void show() {
        System.out.println("Private method");
    }
    public static void main(String[] args) {
        private_access obj = new private_access();
        System.out.println(obj.x);
        obj.show();
    }
}

