using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();

            int
                num1,
                num2,
                num3;

            while (true)
            {
                num1 = ran.Next(1, 10);
                num2 = ran.Next(1, 10);
                num3 = ran.Next(1, 10);

                Console.WriteLine($"Three random numbers: {num1}-{num2}-{num3} | Highest number is: {HighestNumber(num1, num2, num3)}");
                Console.ReadKey(true);
            }

        }

        static int HighestNumber(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }
            if (num3 >= num2 && num3 >= num1)
            {
                return num3;
            }
            else
            {
                throw new Exception("Something went wrong");
            }

        }
    }
}
