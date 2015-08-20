using System;

namespace Exercise8B
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter a 7-bit binary number: ");
			String binary = Console.ReadLine ();

			while (binary.Length != 7) {
				Console.WriteLine ("Please enter a 7-bit binary number: ");
				binary = Console.ReadLine();
			}

			Console.WriteLine (addParityBit(binary));

		}

		public static String addParityBit(string binaryNumber) {

			int count = 0; 

			for (int i = 0; i < binaryNumber.Length; i++) {
				if (binaryNumber.Substring (i, 1) == "1") {
					count++;
				}
			}

			if (count % 2 == 0) {
//				Console.WriteLine (count);
				return binaryNumber + "0";
			} 

			else {
//				Console.WriteLine (count);
				return binaryNumber + "1";
			}
		}
	}
}
