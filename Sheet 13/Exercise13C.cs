using System;

namespace Exercise13C
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int mult = 1;
			int output = 0; 

			Console.WriteLine ("Please enter a number: ");
			int num = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine ("--");

			do {
				output = num * mult;
				Console.WriteLine (output);
				mult++;
			} while(output != (num * 20));
				
		}
	}
}
