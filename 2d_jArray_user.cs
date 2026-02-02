using System;
class jArr{
    static void Main(){
        Console.Write("Enter row size : ");
        int r = int.Parse(Console.ReadLine());

        int[][] arr = new int[r][];

        for(int i = 0;i < arr.GetLength(0);i++){
            Console.Write("Enter column size : ");
            int c = int.Parse(Console.ReadLine());
            arr[i] = new int[c];
        }

        for (int i = 0;i < arr.GetLength(0);i++){
            for (int j = 0;j < arr[i].GetLength(0);j++){
                Console.Write("Enter value : ");
                arr[i][j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        for (int i = 0;i < arr.GetLength(0);i++){
            for (int j = 0;j < arr[i].GetLength(0);j++){
                Console.Write("[{0}][{1}] : {2} ,",i,j,arr[i][j]);
            }
            Console.WriteLine();
        }
    }
}