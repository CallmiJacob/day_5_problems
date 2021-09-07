﻿// C# Program to find whether
// a no is power of two
using System;

class GFG
{

	/* Function to check if
	x is power of 2*/
	static bool isPowerOfTwo(int n)
	{

		if (n == 0)
			return false;

		return (int)(Math.Ceiling((Math.Log(n) /
								Math.Log(2)))) ==
			(int)(Math.Floor(((Math.Log(n) /
								Math.Log(2)))));
	}

	// Driver Code
	public static void Main()
	{
		if (isPowerOfTwo(31))
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");

		if (isPowerOfTwo(64))
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");
	}
}

// This code is contributed
// by Akanksha Rai(Abby_akku)