using System;
class jArr{
    static void Main(){
        int[][] arr = new int[4][];

        arr[0] = new int[3];
        arr[1] = new int[4];
        arr[2] = new int[5];
        arr[3] = new int[6];

        for (int i = 0;i < arr.GetLength(0);i++){
            for (int j = 0;j < arr[i].GetLength(0);j++){
                arr[i][j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
        for (int i = 0;i < arr.GetLength(0);i++){
            for (int j = 0;j < arr[i].GetLength(0);j++){
                Console.Write(arr[i][j]+" ");
            }
            Console.WriteLine();
        }
    }
}