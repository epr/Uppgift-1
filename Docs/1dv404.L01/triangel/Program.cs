using System;

namespace triangel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Tester av konstruktorn med tre double-parametrar");
			Console.WriteLine ("╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍");

			Triangle test1 = new Triangle (2, 2, 2);
			Result ("Tre lika positiva tal", test1.isEquilateral ());

			Triangle test2 = new Triangle (2, 2, 3);
			Result ("Två lika positiva tal och ett tredje tal", test2.isIsosceles ());

			Triangle test3 = new Triangle (2, 3, 4);
			Result ("Tre olika positiva tal", test3.isScalene ());

			Triangle test4 = new Triangle (1.5, 1.5, 1.5);
			Result ("Tre lika positiva tal med decimal", test4.isEquilateral ());

			Triangle test5 = new Triangle (1.5, 1.5, 2.5);
			Result ("Två lika positiva tal med decimal och ett tredje med decimal", test5.isIsosceles ());

			try {
				Triangle test7 = new Triangle (2, 2, 3);
				if (IsTriangle (test7)) {
					Result ("Tre olika positiva tal som inte skapar en triangel", false);
				} else {
					Result ("Tre olika positiva tal som inte skapar en triangel", true);
				}
			} catch {
				Result ("Tre olika positiva tal som inte skapar en triangel", true);
			}

			try {
				Triangle test8 = new Triangle (0, 2, 2);
				if (IsTriangle (test8)) {
					Result ("Två lika positiva tal och noll", false);
				} else {
					Result ("Två lika positiva tal och noll", true);
				}
			} catch {
				Result ("Två lika positiva tal och noll", true);
			}
		}
		public static void Result (string test, bool result) {
			Console.Write (test);
			Console.Write (": ");
			if (result) {
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine ("pass");
			} else {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine ("fail");
			}
			Console.ResetColor ();
		}
		public static bool IsTriangle (Triangle t) {
			if (t.isEquilateral () || t.isIsosceles () || t.isScalene ()) {
				return true;
			} else {
				return false;
			}
		}
	}
}
