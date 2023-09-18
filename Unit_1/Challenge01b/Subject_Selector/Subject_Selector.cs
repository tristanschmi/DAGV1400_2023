using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Grade(%): ");
		Console.WriteLine("Favorite Subject: ");
		
		int grade = Convert.ToInt32(Console.ReadLine());
		string subject = Console.ReadLine();
			
		if (grade >= 90)
			Console.WriteLine("A");
		else if (grade >= 80)
			Console.WriteLine("B");
		else if (grade >= 70)
			Console.WriteLine("C");
		else if (grade >= 60)
			Console.WriteLine("D");
		else 
			Console.WriteLine("F");
		
		if (subject == "Math")
			Console.WriteLine("Take detailed notes, be patient and consult resources.");
		else if (subject == "Science")
			Console.WriteLine("Study more concepts on your own, take detailed notes.");
		else if (subject == "Coding")
			Console.WriteLine("Follow youtube tutorials, dont be afraid to look things up. Read instructions carefully.");
		else if (subject == "Art")
			Console.WriteLine("Be yourself and be creative. There is not right or wrong way with art.");
		else if (subject == "Literature")
			Console.WriteLine("Keep up with reading, take notes on important events and characters. Write within format and be creative with freewrites.");
		else if (subject == "English")
			Console.WriteLine("Takes notes, pay attention to lectures and show up to class. Organize your research well for papers.");
		else if (subject == "History")
			Console.WriteLine("Take many detailed notes. Find a method to memorize, use flashcards and study with classmates.");
		else
			Console.WriteLine("That subject is not available, try another.");
		
	}
		
}		