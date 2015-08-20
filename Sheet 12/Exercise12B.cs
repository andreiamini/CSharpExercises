using System;

namespace Exercise12B
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter a country from (England, Wales, Scotland, Northern Ireland): ");
			String country = Console.ReadLine ();


			switch (country) 
			{
			case "England":
			case "england":
				Console.WriteLine ("The capital of England is London");
				break;
			case "Wales":
			case "wales":
				Console.WriteLine ("The capital of Wales is Cardiff");
				break;
			case "Scotland": 
			case "scotland":
				Console.WriteLine ("The capital of Scotland is Edinburgh");
				break;
			case "Northern Ireland":
			case "northern ireland":
				Console.WriteLine ("The capital of Northern Ireland is Belfast");
				break;
			default: 
				Console.WriteLine ("Sorry, that was not an option.");
				break;
			}
		}
	}
}
