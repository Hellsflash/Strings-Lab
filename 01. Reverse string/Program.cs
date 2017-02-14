using System;
using System.Linq;

namespace _01.Reverse_string
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var result = text.Reverse();

            foreach (var letter in result)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}
