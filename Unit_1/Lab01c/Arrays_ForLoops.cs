using System;
					
public class Program
{
	public static void Main()
	{
		string[] playerTypes = {"Mage", "Knight", "Royal"};
		
		for (var i = 0; i < playerTypes.Length ; i++) {
			playerTypes[i] = "Magician";
		}
		
		foreach(var playerType in playerTypes) {
			Console.WriteLine(playerType);
		}
	}
}