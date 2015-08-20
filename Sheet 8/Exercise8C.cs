using System;

namespace Exercise8C
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter your first name: ");
			String firstName = Console.ReadLine ();

			Console.WriteLine ("Please enter your last name: ");
			String lastName = Console.ReadLine ();

			String firstNameTrim = firstName.Substring(1, 2).ToUpper();
			String lastNameTrim = lastName.Substring(1, 2); 

			String trim = firstNameTrim + lastNameTrim;

			Console.WriteLine (trim);
		}
	}
}
