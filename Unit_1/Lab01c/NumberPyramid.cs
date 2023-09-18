using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Number of Layers: ");
		int layerNumber = Convert.ToInt32(Console.ReadLine());
		for (int i = 1; i <= layerNumber; i++)//input from user with determine the number of rows
		{
			for (int column = 1; column <= i; column++)//number of columns will increment with the number of rows, however this program still increases by 1 each time, rather than rewriting 2 twice, 3 three times and so on
			{
				Console.Write(column + " ");
			}
			Console.WriteLine("\n");
		}
	}
}