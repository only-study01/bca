import java.util.Arrays;

public class array_1d_nd {
    public static void main(String[] args) {
        int[] arr = { 1, 2, 3, 4, 5, 6 }; // 1d array
        // System.out.println(Arrays.toString((arr)));
        for (int i : arr) {
            System.out.print(i + " ");
        }
        System.out.println("\n");

        int[][] arrNd = { // nd array
                { 1, 2, 3 },
                { 4, 5, 6 }
        };

        // System.out.println(Arrays.deepToString((arrNd)));
        for (int[] is : arrNd) {
            for (int n : is) {
                System.out.print(n+" ");
            }
            System.out.println();
        }

        //jagged array

        int[][] jagged = new int[2][];
        jagged[0] = new int[3];
        jagged[1] = new int[4];

        int count = 0;
        for (int i = 0; i < jagged.length; i++)
            for (int j = 0; j < jagged[i].length; j++)
                jagged[i][j] = count++;

        for (int i = 0; i < jagged.length; i++) {
            for (int j = 0; j < jagged[i].length; j++)
                System.out.print(jagged[i][j] + " ");
            System.out.println();
        }
 
        System.out.println(Arrays.deepToString(jagged));
    }
}
