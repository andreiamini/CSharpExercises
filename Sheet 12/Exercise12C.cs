using System;

namespace Exercise12C
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter a letter [A-E]: ");
			String letter = Console.ReadLine ();


			switch (letter) 
			{
			case "A":
			case "a":
				Console.WriteLine ("A stands for Anaconda");
				break;
			case "B":
			case "b":
				Console.WriteLine ("B stands for Ball");
				break;
			case "C": 
			case "c":
				Console.WriteLine ("C stands for Cowboy");
				break;
			case "D":
			case "d":
				Console.WriteLine ("D stands for Deeznuts");
				break;
			case "E":
			case "e":
				Console.WriteLine ("E stands for Entrance");
				break;
			default: 
				Console.WriteLine ("Sorry, you appear to have made an invalid entry. ");
				break;
			}
		}
	}
}
