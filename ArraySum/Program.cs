using System;
using System.Linq;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(SummArray(arr));
        }
        static int SummArray(int[] arr)
        {
            var result = 0;
            result = arr.Sum();
            return result;
        }
    }
}
