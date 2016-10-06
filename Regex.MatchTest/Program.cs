using System;
using System.Text.RegularExpressions;

namespace Regex.MatchTest
{
    class Program
    {
        private const string MatchSuccess = "{0} @{1}:{2}";

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter pattern");
                var pattern = Console.ReadLine();

                Console.WriteLine("Enter Subject");
                var subject = Console.ReadLine();

                var regex = new System.Text.RegularExpressions.Regex(pattern);
                Match match = regex.Match(subject);

                Console.WriteLine(match.Success);
            }
        }
    }
}
