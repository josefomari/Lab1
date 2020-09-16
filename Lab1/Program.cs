using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Program
    {
        static List<string> total = new List<string>();
        static List<ulong> totals = new List<ulong>();
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            WriteNumberLinks(input);
        }

        private static void WriteNumberLinks(string input)
        {

            var r = new Random();
            var sb = new StringBuilder();
            var backString = new StringBuilder();
            var endString = string.Empty;
            for (var i = 0; i < input.Length; i++)
            {
                var a = input[i];
                sb.Append(a);
                for (var j = i + 1; j < input.Length; j++)
                {
                    if (char.IsLetter(input[j])) break;

                    if (a != input[j])
                    {
                        sb.Append(input[j]);
                    }
                    else
                    {
                        sb.Append(input[j]);
                        endString = input.Substring(j + 1);
                        break;
                    }
                }

                if (sb.Length > 1 && sb[0] == sb[sb.Length - 1])
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{backString}");
                    Console.ForegroundColor = (ConsoleColor)r.Next(1, 15);
                    Console.Write($"{sb}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{endString}");
                    Console.WriteLine();
                    total.Add(sb.ToString());
                }

                sb.Length = 0;
                backString.Append(a);
            }

            ulong bigNumber = 0;
            foreach (var number in total)
            {
                totals.Add(Convert.ToUInt64(number));
            }

            foreach (var i in totals)
            {
                bigNumber += i;
            }

            Console.WriteLine($"Total: {bigNumber}");
        }
    }
}
