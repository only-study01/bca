using System;
class jArr{
    static void Main(){
        Console.Write("Enter dim size : ");
        int d = int.Parse(Console.ReadLine());
        int[][][] arr = new int[d][][];

        for (int i = 0;i < arr.Length;i++){
            Console.Write("Enter row's size : ");
            int r = int.Parse(Console.ReadLine());
            arr[i] = new int[r][];
        }

        for (int i = 0;i < arr.Length;i++){
            for (int j = 0;j < arr[i].Length;j++){
                Console.Write("Enter column's size : ");
                int c = int.Parse(Console.ReadLine());
                arr[i][j] = new int[c];
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        for (int i = 0;i < arr.Length;i++){
            for (int j = 0;j < arr[i].Length;j++){
                for (int k = 0;k < arr[i][j].Length;k++){
                    Console.Write("Enter value : ");
                    arr[i][j][k] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        for (int i = 0;i < arr.Length;i++){
            for (int j = 0;j < arr[i].Length;j++){
                for (int k = 0;k < arr[i][j].Length;k++){
                    Console.Write("[{0}][{1}][{2}] : {3} | ",i,j,k,arr[i][j][k]);
                }
            }
            Console.WriteLine();
        }
    }
}