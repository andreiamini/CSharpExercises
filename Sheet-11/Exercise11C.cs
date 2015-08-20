using System;

namespace Exercise11C
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a word: ");
			String word = Console.ReadLine ();

			Console.WriteLine (word + " backwards is " + backwards(word));
		}

		public static String backwards(String wordToBeReversed) {
			char[] charArray = wordToBeReversed.ToCharArray ();

			Array.Reverse (charArray);

			return new string (charArray);
		}
	}
}
