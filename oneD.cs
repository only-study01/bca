using System;
class oned{
    static  void Main(){
        int []a = {12,45,33};
        foreach(int i in a){
            Console.WriteLine(i);
        }

        Console.WriteLine();

        int []arr = new int[5];
        arr[0] = 10;
        arr[1] = 20;
        arr[2] = 30;
        arr[3] = 40;
        arr[4] = 50;

        foreach(int i in arr){
            Console.WriteLine(i);
        }

    }
}