using System;
class dynamic_object{
    static void Main(){
        dynamic a = "Hello";
        Console.WriteLine(a);
        a = 10;
        Console.WriteLine(a);
        a = 10.3;
        Console.WriteLine(a);
        Console.WriteLine("\n");

        object b = "Hello";
        Console.WriteLine(b);
        b = 10;
        Console.WriteLine(b);
        b = 10.5;
        Console.WriteLine(b);
        b = 'a';
        Console.WriteLine(b);
    }
}