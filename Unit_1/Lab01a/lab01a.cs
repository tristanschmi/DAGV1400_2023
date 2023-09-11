using System;
					
public class Program
{
	public static void Main()
	{
		char grade = 'A';//this assigns the variable 'grade' to the letter A, allowing me to input it later in the code
		bool iLikeCSharp = true;
		double pi = 3.1415926535;
		int number = 7;
		int sum = 13 + 7;
		int sum2 = sum + number;//by using the '+' operator here i can add together two variables, in this case 'sum' and 'number'
		int y = 9;
		y += 8;//by using the assignment operator i can give 'y' the value of 9 to start, then use the '+=' operator to achieve 'y = y + 8' resulting in 17
		int x = 16;
		Console.WriteLine("My name is Tristan Schmidt and this is my code");
		Console.WriteLine("My lucky number is " + number);
		Console.WriteLine("Here is an example of a float/double: " + pi);
		Console.WriteLine("T/F, I am enjoying learning C#: " + iLikeCSharp);
		Console.WriteLine("The grade I hope to get in this class is a " + grade);//as seen here, because i assigned 'grade' to the letter A the console will write A any time the variable 'grade' is used
		Console.WriteLine(sum2);
		Console.WriteLine(y);
		Console.WriteLine(x < y);//this results in True because currently y = 17 and x = 16 as was declared earlier in the code
		Console.WriteLine(x != y);//this also results in True becuase it is using the '!=' operator which is declaring that x does not equal y
		Console.WriteLine(x < y && x > 20);//this returns false becuase the 'logical and' operator checks to see if both statements are true, since both of these are not the operator returns false
	}
}