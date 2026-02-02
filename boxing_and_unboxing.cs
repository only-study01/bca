using System;
class boxingAndUnboxing{
	static void Main(){
		int a = 10;
		object b = a; // boxing (implicit)
		int c = (int)b; // unboxing (explicit)
		
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);				
	}
}