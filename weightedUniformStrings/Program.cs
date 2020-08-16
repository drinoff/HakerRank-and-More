using System;
using System.Collections.Generic;
using System.Linq;

namespace weightedUniformStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new Dictionary<char, int>
            {
                ['a'] = 1,
                ['b'] = 2,
                ['c'] = 3,
                ['d'] = 4,
                ['e'] = 5,
                ['f'] = 6,
                ['g'] = 7,
                ['h'] = 8,
                ['i'] = 9,
                ['j'] = 10,
                ['k'] = 11,
                ['l'] = 12,
                ['m'] = 13,
                ['n'] = 14,
                ['o'] = 15,
                ['p'] = 16,
                ['q'] = 17,
                ['r'] = 18,
                ['s'] = 19,
                ['t'] = 20,
                ['u'] = 21,
                ['v'] = 22,
                ['w'] = 23,
                ['x'] = 24,
                ['y'] = 25,
                ['z'] = 26
            };
            var list = new List<long>();
            var text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                list.Add(alphabet[text[i]]);
            }
            var count = list.Count;
            var k = 2;
            for (int i = 0; i < count; i++)
            {
                for (int j = i+1; j < count; j++)
                {
                    
                    if(list[i]==list[j])
                    {
                        list.Add(k * list[i]);
                        k++;
                    }
                    else
                    {
                        k = 2;
                        break;
                    }
                }
            }
            var uniformList = list.Distinct().ToList();
            var inputCount = long.Parse(Console.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    if (uniformList.Contains(input[j]))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
        }
    }
}
