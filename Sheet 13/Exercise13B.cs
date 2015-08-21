using System;

namespace Exercise13B
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int number;

			do {
				Console.WriteLine ("Please enter a positive number that isn't 0: ");
				number = Convert.ToInt32(Console.ReadLine ());
			} while (number <= 0);

			if (number > 0) {
				Console.WriteLine ("Thank you");
			}
		}
	}
}
