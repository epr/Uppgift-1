using System;

namespace triangel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Triangle test1 = new Triangle (2, 2, 2);
			Console.Write ("Test med tre lika positiva tal: ");
			if (test1.isEquilateral ()) {
				Console.WriteLine ("pass");
			} else {
				Console.WriteLine ("fail");
			}

			Triangle test2 = new Triangle (2, 2, 3);
			Console.Write ("Test med två lika positiva tal och ett tredje tal: ");
			if (test2.isIsosceles ()) {
				Console.WriteLine ("pass");
			} else {
				Console.WriteLine ("fail");
			}

			Triangle test3 = new Triangle (2, 3, 4);
			Console.Write ("Test med tre olika positiva tal: ");
			if (test3.isScalene ()) {
				Console.WriteLine ("pass");
			} else {
				Console.WriteLine ("fail");
			}
		}
	}
}
