using System;
using System.Linq;
using System.Collections.Generic;

public struct Point { 
	public double x, y;

	public Point(double a, double b) {
		x = a;
		y = b;
	}
}

public class Triangle {
	double[] sides;

	public Triangle(double a, double b, double c) {
		if ((a > 0) && (b > 0) && (c > 0) && ((a + b) > c) && ((a + c) > b) && ((b + c) > a)) {
			sides = new double[] { a, b, c };
		}
	} 

	public Triangle(double[] s) /*: this (s.Length == 2 ? s[0] : 0, s.Length == 2 ? s[1] : 0, s.Length == 2 ? s[2] : 0) */{
		if ((s.Length == 3) && (s[0] > 0) && (s[1] > 0) && (s[2] > 0) && ((s[0] + s[1]) > s[2]) && ((s[0] + s[2]) > s[1]) && ((s[1] + s[2]) > s[0])){
			sides = new double[3];
			for(int i=0;i<s.Length;i++)
				sides[i]=s[i];
		}
	} 

	public Triangle(Point a, Point b, Point c) {
		sides = new double[3];
		sides[0] = Math.Sqrt(Math.Pow((b.x - a.x), 2.0) + Math.Pow((b.y - a.y), 2.0));
		sides[1] = Math.Sqrt(Math.Pow((b.x - c.x), 2.0) + Math.Pow((b.y - c.y), 2.0));
		sides[2] = Math.Sqrt(Math.Pow((c.x - a.x), 2.0) + Math.Pow((c.y - a.y), 2.0));
		Console.WriteLine (sides [0]);
		Console.WriteLine (sides [1]);
		Console.WriteLine (sides [2]);

	}

	public Triangle(Point[] s) {
		sides = new double[s.Length];
		sides[0] = Math.Sqrt(Math.Pow((s[1].x - s[0].x), 2.0) + Math.Pow((s[1].y - s[0].y), 2.0));
		sides[1] = Math.Sqrt(Math.Pow((s[1].x - s[2].x), 2.0) + Math.Pow((s[1].x - s[2].x), 2.0));
		sides[2] = Math.Sqrt(Math.Pow((s[2].x - s[0].x), 2.0) + Math.Pow((s[2].x - s[0].x), 2.0));
	}

	private int uniqueSides() {
		try {
			return sides.Distinct<double>().Count();
		}
		catch {
			return 0;
		}
	}

	public bool isScalene() {
		if(uniqueSides() == 3)
			return true;
		return false;
	}

	public bool isEquilateral() {
		if(uniqueSides() == 1)
			return true;
		return false;
	}

	public bool isIsosceles() {
		if(uniqueSides() == 2)
			return true;
		return false;
	}
}