using System;
class Program{
    static int[,] ans;
    static int countAns = 0;

    static void Helper(int[,] arr,int n){
        
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++){
            for (int j = 0; j < arr.GetLength(1); j++){
                if(n == arr[i,j]){
                 count++;
                }
            }

            ans[countAns, 0] = n;
            ans[countAns, 1] = count;
            countAns++;
        }
    }
    static void countValue(int [,] arr){
        int sizeSub = 0;
        ans = new int[arr.Length,2];
        int [] countA = new int[arr.Length];
        for (int i = 0; i < arr.GetLength(0);i++){
            for (int j = 0; j < arr.GetLength(1); j++){
                bool findV = true;
                for (int x = 0; x < sizeSub;x++){
                    if (arr[i, j] == countA[x]){
                        findV = false;
                        break;
                    }
                }

                if(findV){
                    Helper(arr, arr[i, j]);
                    countA[sizeSub] = arr[i,j];
                    sizeSub++;
                }
            }
        }
    }
    static void Main(string[] args){
        Console.WriteLine("Enter row and column size : ");
        Console.Write("Enter row size : ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Enter column size : ");
        int c = int.Parse(Console.ReadLine());
        int [,] arr = new int[r,c];

        for (int i = 0; i < arr.GetLength(0);i++){
            for (int j = 0; j < arr.GetLength(1);j++){
                Console.Write("Enter value of [{0},{1}] : ",i,j);
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }

        countValue(arr);

        for (int i = 0; i < countAns; i++){
            if (ans[i,1] > 1){
                Console.WriteLine(ans[i,0] + " : " + ans[i,1]);
            }
        }
        Console.ReadLine();
    }
  }
