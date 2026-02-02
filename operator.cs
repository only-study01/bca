using System;
class allOperator{
    static void Main(){
        int a = 10;
        int b = 3;
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));      // integer division
        Console.WriteLine("Modulus: " + (a % b));

        a++; // increment
        Console.WriteLine("After Increment a: " + a);

        b--; // decrement
        Console.WriteLine("After Decrement b: " + b);

    }    
}