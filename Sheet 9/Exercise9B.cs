using System;

namespace Exercise9B
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool repeat = false; 
			int[] array = generateRandomArray ();

			while (repeat == false) {
				Console.WriteLine ("Please enter a number");
				int number  = Convert.ToInt32(Console.ReadLine ());

				Console.WriteLine(doesItAppearInTheArray (array, number));
			}


		}

		public static int[] generateRandomArray() {
			int[] randomArray = new int[100]; 
			Random random = new Random ();

			for (int i = 0; i < 100; i++) {
				int num = random.Next (0, 100);
//				Console.WriteLine (num);

				randomArray [i] = num;
			}

			return randomArray;
		}

		public static String doesItAppearInTheArray(int[] numberArray, int number) {
			for (int i = 0; i < numberArray.Length - 1; i++) {
				if (numberArray[i] == number) {
					return "The number " + number + " first appears at position " + i + " in the array. ";
				}
			}

			return "The number does not appear in the array. ";
		}
	}
}
