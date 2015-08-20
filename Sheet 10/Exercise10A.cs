using System;

namespace Exercise10A
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter the number of segments in your tree: ");
			int numberOfSegments = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Please enter the height of the trunk: ");
			int height = Convert.ToInt32(Console.ReadLine ());

			tree (numberOfSegments, height);
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

		public static void body(int segments) {
			for (int i = 0; i < segments; i++) {
				Console.WriteLine ("   XXXXXXXXXXXX   ");
				Console.WriteLine ("  XXXXXXXXXXXXXX  ");
				Console.WriteLine (" XXXXXXXXXXXXXXXX ");
				Console.WriteLine ("XXXXXXXXXXXXXXXXXX");
			}
		}

		public static void tree(int height, int baseLength) {
			triangle ();
			body (height);
			trunk (baseLength);

		}
	}
}

