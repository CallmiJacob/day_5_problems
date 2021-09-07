// C# program program to
// check for even or odd
using System;
using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
class Program
{
    // Returns true if n is even, else odd
    public static bool isEven(int n)
    {
        return (n % 2 == 0);
    }

    // Driver code
    public static void Main()
    {
        int n = 101;
        if (isEven(n) == true)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}