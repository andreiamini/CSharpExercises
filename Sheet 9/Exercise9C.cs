using System;

namespace Exercise9A
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] nameArray = new string[5];

			Console.WriteLine ("Please enter name 1: ");
			nameArray[0] = Console.ReadLine ();

			Console.WriteLine ("Please enter name 2: ");
			nameArray[1] = Console.ReadLine ();

			Console.WriteLine ("Please enter name 3: ");
			nameArray[2] = Console.ReadLine ();

			Console.WriteLine ("Please enter name 4: ");
			nameArray[3] = Console.ReadLine ();

			Console.WriteLine ("Please enter name 5: ");
			nameArray[4] = Console.ReadLine ();

			Console.WriteLine ("Well Done " + pickRandomName (nameArray) + " you are the winner!");

		}

		public static String pickRandomName(string[] names) {
			
			Random random = new Random ();
			int i = random.Next (0, 5);

			String randomName = names[i];

			return randomName;
		}
	}
}
