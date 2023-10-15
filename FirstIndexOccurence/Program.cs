using System;
using System.Linq;

namespace FirstIndexOccurence
{
    class Program
    {
        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
                return haystack.IndexOf(needle);
            else
                return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write the first word: ");
            string str = Console.ReadLine();
            Console.WriteLine("Write the needle: ");
            string word = Console.ReadLine();
            int index = StrStr(str, word);
            Console.WriteLine("Index is: " + index);
        }
    }
}
