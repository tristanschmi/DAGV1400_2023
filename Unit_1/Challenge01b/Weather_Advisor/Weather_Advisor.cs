using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Temperature(Celcius): ");
		
		int temperature = Convert.ToInt32(Console.ReadLine());
		
		if (temperature >= 100)
			Console.WriteLine("The sun has gone supernova, humanity is lost.");
		else if (temperature >= 50)
			Console.WriteLine("You might die if you go outside.");
		else if (temperature >= 37)
			Console.WriteLine("It is very hot outside, stay out of the sun if you can");
		else if (temperature >= 30)
			Console.WriteLine("Stay hydrated and don't stay in the sun too long!");
		else if (temperature >= 20)
			Console.WriteLine("Wear a light jacket.");
		else if (temperature >= 10)
			Console.WriteLine("It's getting chilly, wear warmer clothing.");
		else if (temperature >= 1)
			Console.WriteLine("It's nearing freezing point, wear a heavy coat.");
		else if (temperature <= 0)
			Console.WriteLine("It is freezing outside, be safe!");
		else
			Console.WriteLine("Enjoy the weather!");
		
	}
}