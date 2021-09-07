
// C# program to check if a given
// character is vowel or consonant
using System;
public class Program
{

    // Function to check whether a
    // character is vowel or not
    static void vowelOrConsonant(char x)
    {
        if (x == 'a' || x == 'e' || x == 'i' ||
            x == 'o' || x == 'u' || x == 'A' ||
            x == 'E' || x == 'I' || x == 'O' || x == 'U')
            Console.WriteLine("Vowel");
        else
            Console.WriteLine("Consonant");
    }

    // Driver code
    static public void Main()
    {
        vowelOrConsonant('c');
        vowelOrConsonant('E');
    }
}
