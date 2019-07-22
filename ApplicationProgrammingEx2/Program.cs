using System;
using System.Text.RegularExpressions;

namespace ApplicationProgrammingEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
            Console.WriteLine("Aptech Computer Center: ");
            var _string = Console.ReadLine();
            Console.WriteLine("Enter a word to search: ");
            var _word = Console.ReadLine();
            var _found = Regex.Matches(_string, _word).Count;
            Console.WriteLine("Word found {0} times in the string", _found);
        }
    }
}