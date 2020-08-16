using System;
using System.Text;

namespace letsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            StringBuilder sbEven = new StringBuilder();
            StringBuilder sbOdd = new StringBuilder();


            for (int i = 0; i < count; i++)
            {
                var text = Console.ReadLine();
                for (int j = 0; j < text.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        sbEven.Append(text[j]);
                    }
                    else
                    {
                        sbOdd.Append(text[j]);
                    }
                }
                Console.WriteLine($"{sbEven} {sbOdd}");
                sbEven.Clear();
                sbOdd.Clear();
            }
        }
    }
}
