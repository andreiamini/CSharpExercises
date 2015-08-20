using System;

namespace Exercise12A
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int rightCount = 0;
			Console.WriteLine ("To answer this multiple choice quiz, enter A, B or C...");
			Console.WriteLine ("");

			Console.WriteLine ("1) What is the capital of Guatemala?");
			Console.WriteLine ("A: Lisbon, B: Tegucigalpa, C: Guatemala City");

			String answer1 = Console.ReadLine ();


			switch (answer1) 
			{
			case "A":
				Console.WriteLine ("Incorrect");
				break;
			case "B":
				Console.WriteLine ("Correct");
				rightCount += 1;
				break;
			case "C": 
				Console.WriteLine ("Incorrect");
				break;
			default: 
				Console.WriteLine ("Sorry, that was not an option.");
				break;
			}

			Console.WriteLine ("");
			Console.WriteLine ("2) Which team won the NBA final in 2015?");
			Console.WriteLine ("A: Golden State Warriors, B: Dallas Mavericks, C: Miami Heat");

			String answer2 = Console.ReadLine ();


			switch (answer2) 
			{
			case "A":
				Console.WriteLine ("Correct");
				rightCount += 1;
				break;
			case "B":
				Console.WriteLine ("Incorrect");
				break;
			case "C": 
				Console.WriteLine ("Incorrect");
				break;
			default: 
				Console.WriteLine ("Sorry, that was not an option.");
				break;
			}

			Console.WriteLine ("");
			Console.WriteLine ("3) Who plays James Bond in Skyfall?");
			Console.WriteLine ("A: Pierce Brosnan, B: Daniel Craig, C: Sean Connery");

			String answer3 = Console.ReadLine ();


			switch (answer3) 
			{
			case "A":
				Console.WriteLine ("Incorrect");
				break;
			case "B":
				Console.WriteLine ("Correct");
				rightCount += 1;
				break;
			case "C": 
				Console.WriteLine ("Incorrect");
				break;
			default: 
				Console.WriteLine ("Sorry, that was not an option.");
				break;
			}

			Console.WriteLine ("");
			Console.WriteLine ("4) What is the name of the album that Lana del Rey dropped in 2015? ");
			Console.WriteLine ("A: Hollywood, B: Honeydew, C: Honeymoon");

			String answer4 = Console.ReadLine ();


			switch (answer4) 
			{
			case "A":
				Console.WriteLine ("Incorrect");
				break;
			case "B":
				Console.WriteLine ("Incorrect");
				break;
			case "C": 
				Console.WriteLine ("Correct");
				rightCount += 1;
				break;
			default: 
				Console.WriteLine ("Sorry, that was not an option.");
				break;
			}

			Console.WriteLine ("");
			Console.WriteLine ("5) Fill in the lyric: 'A ______ flew across the room before you came' ");
			Console.WriteLine ("A: Potato, B: Tornado, C: Sandal");

			String answer5 = Console.ReadLine ();


			switch (answer5) 
			{
			case "A":
				Console.WriteLine ("Correct");
				rightCount += 1;
				break;
			case "B":
				Console.WriteLine ("Incorrect");
				break;
			case "C": 
				Console.WriteLine ("Incorrect");
				break;
			default: 
				Console.WriteLine ("Sorry, that was not an option.");
				break;
			}

			Console.WriteLine ("");
			Console.WriteLine ("You scored: " + rightCount + " points");
		}
	}
}
