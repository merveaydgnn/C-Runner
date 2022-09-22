using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumOfMultiple;
using SequenceAnalysis;
namespace Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            sumOfMultiple sum = new sumOfMultiple();
            alphabeticalOrder alphabeticalOrder = new alphabeticalOrder();

            Console.WriteLine("  Which of the following questions would you like to solve ? : ");
            Console.WriteLine("1)  Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input."
                + "\n" + "2)  Find the uppercase words in a string, provided as input, and order all characters in these words alphabetically");

            int selection = Convert.ToInt32(Console.ReadLine());

            if (selection == 1)
            {
                sum.sumCalculate();
            }

            else
            {
                alphabeticalOrder.order();
            }
           
        }
    }
}
