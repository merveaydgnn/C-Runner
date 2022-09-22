using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiple
{
    public class sumOfMultiple
    {
        public void sumCalculate()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt16(Console.ReadLine());

            int total = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }
            Console.WriteLine("Total : " + total);
            Console.ReadLine();
        }
    }
}
