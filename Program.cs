using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extracting_String_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method ExtractString Started");
            Console.WriteLine("------------------------------");
            int firstHashIndex = input.IndexOf("##");
            int lastHashIndex = input.LastIndexOf("##");

            if (firstHashIndex != -1 && lastHashIndex != -1 && firstHashIndex < lastHashIndex)
            {


                return input.Substring(firstHashIndex + 2, lastHashIndex - firstHashIndex - 2);
            }


            Console.WriteLine("Method ExtractString Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            return string.Empty;
        }

        public static int HowManyOccurrences(string mainString, string substring)
        {
            Console.WriteLine("Method HowManyOccurrences Started");
            Console.WriteLine("------------------------------");
            int count = 0;
            int index = mainString.IndexOf(substring);

            while (index != -1)
            {
                count++;
                index = mainString.IndexOf(substring, index + 1);
            }

            Console.WriteLine("Method HowManyOccurrences Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            return count;
        }
    }
}
