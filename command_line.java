import java.util.Arrays;

public class command_line {
    public static void main(String[] args) {

        // Print first argument
        System.out.println("First argument: " + args[0]);

        // Sort command line arguments
        Arrays.sort(args);

        // Print sorted arguments
        System.out.println("Sorted arguments: " + Arrays.toString(args));
    }
}
