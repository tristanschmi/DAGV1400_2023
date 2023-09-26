using System;

namespace FavoriteFoods

{
    public class Program
    {
        public static void Main(string[] args)
			
			
        {
			
			string[] Food = new string[3];
			Food[0] = ("favoriteFood1");
			Food[1] = ("favoriteFood2");
			Food[2] = ("favoriteFood3");
			
 			Console.WriteLine("Enter your three favorite foods:"); 
            foreach (string s in Food) 
            {
            	Food[0] = Console.ReadLine();
				Food[1] = Console.ReadLine();
				Food[2] = Console.ReadLine();//having all three of these here makes it so that it wont move on until 9 strings have been entered, however i couldn't get it to work otherwise
            }
			
            foreach (string s in Food)
            {
                Console.WriteLine("I love " + s + "!");
            }
        }
    }
}