using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Temperature(Celcius): ");
		
		int temperature = Convert.ToInt32(Console.ReadLine());
		
		if (temperature >= 30)
			Console.WriteLine("Stay hydrated, dont stay in the sun too long!");
		else
			Console.WriteLine("Enjoy the weather!");
		
	}
}