using System;
class oned{
    static  void Main(){
        int [,]a = {{1,2,3},{4,5,6},{7,8,9}};

        for (int i = 0;i < a.GetLength(0);i++){
            for (int j = 0;j < a.GetLength(1);j++){
                Console.Write(a[i,j]+" ");
            }
        }

        Console.WriteLine();

        int [,]arr = new int[2,5];
        
        for (int i = 0;i < arr.GetLength(0);i++){
            for (int j = 0;j < arr.GetLength(1);j++){
               arr[i,j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        for (int i = 0;i < arr.GetLength(0);i++){
            for (int j = 0;j < arr.GetLength(1);j++){
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();
        }

    }
}