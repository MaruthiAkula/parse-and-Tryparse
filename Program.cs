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
            string number = "1000";
            int i = int.Parse(number);
            Console.WriteLine(i);
            string number_plus_characters = "1000bhehchd";
            bool issuccessful= int.TryParse(number_plus_characters, out result);
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
