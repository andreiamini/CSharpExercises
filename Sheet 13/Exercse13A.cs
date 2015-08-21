using System;

namespace Exercise13A
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int number;

			do {
				Console.WriteLine ("Please enter a positive number that isn't 0: ");

				number = Convert.ToInt32(Console.ReadLine ());

				if (number <= 0) {
					Console.WriteLine(number + " is not a valid input");
					Console.WriteLine("--");
				} else {
					Console.WriteLine(checkPrime(number));
					Console.WriteLine("--");
				}

			} while (true);
				
		}

		public static String checkPrime(int num) {
			
			if (num == 1) {
				return num + " is not a prime";
			}

			for (int i = 2; i <= num - 1; i++) {
				if (num % i == 0) {
					return num + " is not a prime";
				} 
			}

			return num + " is a prime";
		}

	}
}
