using System;
using System.Linq;

namespace compareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bob = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var pointsAlice = 0;
            var pointsBob = 0;
            for (int i = 0; i < alice.Length; i++)
            {
                if(alice[i]>bob[i])
                {
                    pointsAlice++;
                }
                else if(alice[i]<bob[i])
                {
                    pointsBob++;
                }
                
            }
            Console.WriteLine($"{pointsAlice} {pointsBob}");
        }
    }
}
