using System;
using System.Collections.Generic;

namespace Exercise9AA
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int number = 10000;
			sieve (number);
		}

		public static void sieve(int numbers) { 
			bool[] primeOrNah = new bool[numbers];
			for (int i = 2; i < numbers; i++)
			{
				primeOrNah[i] = true;
			}

			for (int j = 2; j < numbers; j++)
			{
				if (primeOrNah[j])
				{
					for (int p = 2; (p*j) < numbers; p++)
					{
						primeOrNah[p * j] = false;
					}
				}
			}

			for (int k = 0; k < primeOrNah.Length; k++) {
				if (primeOrNah[k] == true) {
					Console.WriteLine (k);
				}
			}
		}
	}
}
