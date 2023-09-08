using System;

public class Program
{
		public Stock lemonade;
		public Profit profit;//Im not sure if this was the correct way to do this, but this is what ended up allowing me to have both profit and lemonade exist in the same Main
		
        public void Main()
        {
			profit = new Profit();
			lemonade = new Stock();
			lemonade.stockCount--;//Here is where the code will decrease the stock count by 1 every time that the program is run
			profit.profitCount++;//Here is where the code will increase the profit count by 1 every time the program is run
			Console.WriteLine("Lemonade Stand");//For this challenge I wanted to mess around with value changes and increment/decrement so I decided on a Lemonade Stand example with stock and profit
			Console.WriteLine(lemonade.stockName + " stock = " + lemonade.stockCount);
			Console.WriteLine(profit.profitName + " = " + profit.profitCount);
			
        }		
    }
public class Stock {
		public int stockCount = 100;//Here I was able to set the default value that the stock will always start at
		public string stockName = "Lemonade";//Naming the lemonade
}
public class Profit {
		public int profitCount = 0;//Here I set the defaul value that the profit will always start at
		public string profitName = "Profit";//Naming the profit
}//Though this is a very basic example, since I am new to cs it was interesting for me to experiment with operators that can change the values of variables