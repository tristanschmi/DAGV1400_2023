
using System;

public class Program
{
    public void Main ()
    {
        Console.WriteLine("ようこそ");
        DoMath(14, 3);
        DoMath(34, 2);
        DoMath(7, 21);
        Compare(13, 3);
		Compare(9, 4);
		CheckPassword("4815162342");
    }
    public void DoMath(int value, int value2) {
        var number = value + value2;
        Console.WriteLine(number);
    }
    
    public void Compare (int value, int value2) {
        if(value > value2) {
            Console.WriteLine("True, the first is greater.");
        } else {
		Console.WriteLine("False, the second is greater.");
		}
    }
	
	public void CheckPassword (string password) {
		if(password == "4815162342") {
			Console.WriteLine("Correct");
		} else {
			Console.WriteLine("Incorrect");
		}
	}  
}
    