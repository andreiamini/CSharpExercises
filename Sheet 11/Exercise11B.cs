using System;

namespace Exercise11B
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a decimal number: ");
			int number = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Decimal " + number + " = Binary " + dec_to_bin (number));
		}

		public static String dec_to_bin(int dec){
			String bin = Convert.ToString(dec, 2);
			return bin;
		} 
	}
}
