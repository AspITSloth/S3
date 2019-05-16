using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();

            int[] numbers = new int[10];

            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = ran.Next(1, 21);
                }

                foreach (var number in OrderNum(numbers))
                {
                    Console.WriteLine(number);
                }
                Console.ReadKey(true);

            }
        }

        static List<int> OrderNum(int[] numbers)
        {
            var orderedNum = numbers.ToList().OrderBy(n => n) as List<int>;
            return orderedNum;
        }
    }
}
