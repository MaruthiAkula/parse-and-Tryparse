using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse_and_Tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Enter Any for parse");
            string s1 = Console.ReadLine();
           // string number = "1000";
            int i = int.Parse(s1);
            Console.WriteLine(i);
            Console.WriteLine("Enter Any for Tryparse");
            string s = Console.ReadLine();
            // string number_plus_characters = "1000b";
            bool issuccessful = int.TryParse(s, out result);
            if (issuccessful)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Enter valid number");
            }
        }
    }
}
