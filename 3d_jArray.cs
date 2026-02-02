using System;
class jArr{
    static void Main(){
        int[][][] arr = new int[2][][];

        //  row's

        arr[0] = new int[3][];
        arr[1] = new int[4][];


        // col's

        arr[0][0] = new int[2];
        arr[0][1] = new int[3];
        arr[0][2] = new int[4];

        arr[1][0] = new int[4];
        arr[1][1] = new int[2];
        arr[1][2] = new int[3];
        arr[1][3] = new int[5];



        Console.WriteLine();
        for (int i = 0;i < arr.Length;i++){
            for (int j = 0;j < arr[i].Length;j++){
                for (int k = 0;k < arr[i][j].Length;k++){
                    Console.Write(arr[i][j][k]+" ");
                }
            }
            Console.WriteLine();
        }
    }
}