using System;

namespace Exercise11A
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a decimal number: ");
			int number = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Decimal " + number + " = Hexadecimal " + dec_to_hex (number));
		}

		public static String dec_to_hex(int dec){
			String hex = Convert.ToString(dec, 16);
			return hex;
		} 
	}
}

