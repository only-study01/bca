using System;
class HotalMenu{
    static void Main(){
        int[,] total_bill = new int[4,4];
        string[]  menu = {
            "1. pizza - 99₹",
            "2. burger - 49₹",
            "3. shake - 39₹",
            "4. sandwich - 29₹",
        };

        while (true){
            Console.Clear();
            int[] price = {99,49,39,29};

            Console.WriteLine("Hotal Menu");
            Console.WriteLine("Select One Item :");
            foreach(string i in menu){
                Console.WriteLine(i);
            }
            Console.WriteLine("5. exit");

            Console.Write("Enter your choice : ");
            int a = int.Parse(Console.ReadLine());

            switch (a){
                case 1:
                    Console.WriteLine("Pizza");
                    total_bill[0,0] = a;
                    total_bill[0,1]++;
                    break;
                case 2:
                    Console.WriteLine("Burger");
                    total_bill[1,0] = a;
                    total_bill[1,1]++;
                    break;
                case 3:
                    Console.WriteLine("Shake");
                    total_bill[2,0] = a;
                    total_bill[2,1]++;
                    break;
                case 4:
                    Console.WriteLine("sandwich");
                    total_bill[3,0] = a;
                    total_bill[3,1]++;
                    break;
                case 5:
                    Console.WriteLine("Thank you");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }       
            Console.ReadLine();
        }

        Console.WriteLine("Hotal Bill");
        for(int i = 0;i < total_bill.GetLength(0);i++){
            Console.WriteLine(menu[total_bill[i,0]] + " : " + total_bill[i,1]);
        }
    }
}