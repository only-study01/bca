using System;
class checkNum{
    static void Main(){
        Console.Write("Enter a number : ");
        int a = int.Parse(Console.ReadLine());

        if (a > 0){
            Console.WriteLine("Number is positive");        
        } else if (a < 0){
            Console.WriteLine("Number is negative");        
        } else {
            Console.WriteLine("Number is zero");        
        }
    }
}