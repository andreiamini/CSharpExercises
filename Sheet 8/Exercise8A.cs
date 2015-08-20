using System;

namespace Exercise8A
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter a sentence: ");
			String input = Console.ReadLine ();

			input = removeSpaces (input);
			input = reverseSentence (input);
			input = toggleCase (input);

			Console.WriteLine (input);


		}

		public static String reverseSentence(String sentence) {

			char[] reversedSentence = sentence.ToCharArray ();
			Array.Reverse (reversedSentence);

			return new string (reversedSentence);
		}

		public static String removeSpaces(String sentence) {
			sentence = sentence.Replace (" ", "");

			return sentence;
		}

		public static String toggleCase(String sentence) {

			String toggledSentence = "";

			char[] charArray = sentence.ToCharArray ();
				
			for (int i = 0; i < charArray.Length; i++) {
				if (i % 2 == 0)
					toggledSentence += Char.ToUpper (charArray[i]);
				else
					toggledSentence += Char.ToLower (charArray[i]);
			}

			return toggledSentence;
		} 
	}
}
