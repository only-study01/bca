// using System;
class UserInput{
    static void Main(){
        Console.Write("Enter your name : ");
        string a = Console.ReadLine();
        Console.WriteLine("Hello " + a);

        Console.Write("Enter Age : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Age is : " + b);

        // float 

        Console.Write("Enter height : ");
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine("Age height  : " + c);
    }
}