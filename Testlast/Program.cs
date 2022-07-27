using System;
using System.Linq;
using System.Collections.Generic;

namespace Testlast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("45 34 24 108 76 58 64 130 80 // 130 24 34 80 108 45 64 58 76");
            Console.WriteLine("Answer:");
            Console.WriteLine(Order("45 34 24 108 76 58 64 130 80"));

            Console.WriteLine("2022 70 123    3344 13 // 13 123 2022 70 3344");
            Console.WriteLine("Answer:");
            Console.WriteLine(Order("    2022 70 123    3344 13 "));

            Console.WriteLine("17565 353067 443391 84570 88144");
            Console.WriteLine("Answer:");
            Console.WriteLine(Order("443391 353067 17565 84570 88144"));

            Console.WriteLine(Order("284344 441269 406574 84187 269096 385259 384458 176496 82996"));

            Console.WriteLine(Order("3 16 9 38 95 1131268 49455 347464 59544965313 496636983114762 85246814996697 85246814996697123124 85246814996697124124124124 8524681499669712412412412485246814996697124124124124"));
            Console.ReadKey();
        }
        public static string Order(string input)
        {
            string result = null;
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }
            string[] arrnumb = input.Split(" ");
            List<string> Listnum = new List<string>();
            foreach (string numb in arrnumb)
            {
                if (numb != "")
                {
                    Listnum.Add(numb);
                }
            }
            var OrdStr = from num in Listnum orderby num select num;
            var OrdStrEnd = from num in OrdStr orderby num.Sum(ch => ch - '0') select num;

            foreach (string num in OrdStrEnd)
            {
                result += num + " ";
            }

            return result.Trim();
        }
    }
}
