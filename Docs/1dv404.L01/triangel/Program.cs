using System;

namespace triangel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Tester av konstruktorn med tre double-parametrar");
			Console.WriteLine ("╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍");

			Console.WriteLine ("Trianglar");
			Console.WriteLine ("╌╌╌╌╌╌╌╌╌");

			Triangle test1 = new Triangle (2, 2, 2);
			Result ("Tre lika positiva tal", test1.isEquilateral ());

			Triangle test2 = new Triangle (2, 2, 3);
			Result ("Två lika positiva tal och ett tredje tal", test2.isIsosceles ());

			Triangle test3 = new Triangle (2, 3, 4);
			Result ("Tre olika positiva tal", test3.isScalene ());

			Triangle test4 = new Triangle (1.5, 1.5, 1.5);
			Result ("Tre lika positiva tal med decimal", test4.isEquilateral ());

			Triangle test5 = new Triangle (1.5, 1.5, 2.5);
			Result ("Två lika positiva tal med decimal och ett tredje tal med decimal", test5.isIsosceles ());

			Triangle test6 = new Triangle (3.5, 4.5, 5.5);
			Result ("Tre olika positiva tal med decimal", test6.isScalene ());

			Console.WriteLine ();
			Console.WriteLine ("Icke-trianglar");
			Console.WriteLine ("╌╌╌╌╌╌╌╌╌╌╌╌╌╌");

			Triangle test7 = new Triangle (1, 2, 3);
			Result ("Tre olika positiva tal som inte skapar en triangel", !IsTriangle (test7));

			Triangle test8 = new Triangle (0, 1, 1);
			Result ("Två lika positiva tal och noll", !IsTriangle (test8));

			Triangle test9 = new Triangle (-1, 1, 1);
			Result ("Två lika positiva tal och ett negativt tal", !IsTriangle (test9));

			Triangle test10 = new Triangle (-1, -1, -1);
			Result ("Tre lika negativa tal", !IsTriangle (test10));

			Console.WriteLine ();
			Console.WriteLine ("Tester av konstruktorn med en double array-parameter");
			Console.WriteLine ("╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍");

			Console.WriteLine ("Trianglar");
			Console.WriteLine ("╌╌╌╌╌╌╌╌╌");

			Triangle test11 = new Triangle (new double[]{ 2, 2, 2 });
			Result ("Tre lika positiva tal", test11.isEquilateral ());

			Triangle test12 = new Triangle (new double[]{ 2, 2, 3 });
			Result ("Två lika positiva tal och ett tredje tal", test12.isIsosceles ());

			Triangle test13 = new Triangle (new double[]{ 2, 3, 4 });
			Result ("Tre olika positiva tal", test13.isScalene ());

			Triangle test14 = new Triangle (new double[]{ 1.5, 1.5, 1.5 });
			Result ("Tre lika positiva tal med decimal", test14.isEquilateral ());

			Triangle test15 = new Triangle (new double[]{ 1.5, 1.5, 2.5 });
			Result ("Två lika positiva tal med decimal och ett tredje tal med decimal", test15.isIsosceles ());

			Triangle test16 = new Triangle (new double[]{ 3.5, 4.5, 5.5 });
			Result ("Tre olika positiva tal med decimal", test16.isScalene ());

			Console.WriteLine ();
			Console.WriteLine ("Icke-trianglar");
			Console.WriteLine ("╌╌╌╌╌╌╌╌╌╌╌╌╌╌");

			Triangle test17 = new Triangle (new double[]{ 1, 2, 3 });
			Result ("Tre olika positiva tal som inte skapar en triangel", !IsTriangle (test17));

			Triangle test18 = new Triangle (new double[]{ 0, 1, 1 });
			Result ("Två lika positiva tal och noll", !IsTriangle (test18));

			Triangle test19 = new Triangle (new double[]{ -1, 1, 1 });
			Result ("Två lika positiva tal och ett negativt tal", !IsTriangle (test19));

			Triangle test20 = new Triangle (new double[]{ -1, -1, -1 });
			Result ("Tre lika negativa tal", !IsTriangle (test20));
		}
		public static void Result (string test, bool result) {
			if (result) {
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write ("Pass");
			} else {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write ("Fail");
			}
			Console.ResetColor ();
			Console.Write (": ");
			Console.WriteLine (test);
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
