public class loop {
    public static void main(String[] args) {
        int[] a = {1,2,3,4,5,6,7,8,9};

        for(int i = 0;i < a.length;i++){
            System.out.print(i + " ");
        }

        System.out.println();

        int i = 0;
        while (i < a.length) {
            System.out.print(i + " ");
            i++;
        }

        System.out.println();
        i = 0;
        do{
            System.out.print(i + " ");
            i++;
        }while(i < a.length);

        System.out.println();

        for (int val : a) {
            System.out.print(val + " ");
        }
    }
}
