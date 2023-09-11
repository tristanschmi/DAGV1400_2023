using System;
					
public class Program
{
	public GameStates gameStates;
	public void Main()
	{
		gameStates = new GameStates();
		gameStates.currentState = GameStates.States.CharacterDeath;
		gameStates.CheckState();
	}
}

public class GameStates {
	
	public enum States {
		Starting,//enum is like a label to put onto another section of the code, in this case 'Starting'
		Playing,
		CharacterDeath,
		Ending
	}
	
	public States currentState = States.Starting;
	public void CheckState () {
		switch (currentState) {
			case States.Starting://case is like an if statement but can reference specified enums that have been previously declared
				Console.WriteLine("Starting");
				break;
			case States.Playing:
				Console.WriteLine("Playing");
				break;
			case States.CharacterDeath:
				Console.WriteLine("You Died!");
				break;
			case States.Ending:
				Console.WriteLine("Ending");
				break;
		}
	}

}