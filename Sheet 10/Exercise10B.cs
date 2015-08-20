using System;

namespace Exercise10B
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter the height of the trunk: ");
			int height = Convert.ToInt32(Console.ReadLine ());

			trunk (height);
		}

		public static void triangle() {
			Console.WriteLine ("        XX        ");
			Console.WriteLine ("       XXXX       ");
			Console.WriteLine ("      XXXXXX      ");
			Console.WriteLine ("     XXXXXXXX     ");
			Console.WriteLine ("    XXXXXXXXXX    ");

		}

		public static void trunk(int size) {
			for (int i = 0; i < size; i++) {
				Console.WriteLine ("       ####");
			}
		}
	}
}
