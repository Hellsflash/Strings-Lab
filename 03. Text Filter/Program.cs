using System;
using System.Linq;

namespace _03.Text_Filter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine()
                .Split(new[] {',',' '},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var text = Console.ReadLine().ToString();


            foreach (var word in bannedWords)
            {


                text = text.Replace(word, new string('*', word.Length));

            }
            Console.WriteLine(text);

        }
    }
}
