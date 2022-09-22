using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SequenceAnalysis
{
    public class alphabeticalOrder
    {
        public void order()
        {
            Console.Write("Input the string : ");
            String write = Console.ReadLine();
            

            int length = write.Length;
            char[] array = new char[length];

            String serial = "Alphabetical order of capital letters = ";


            for (int i = 0; i < length; i++)
            {
                array[i] = write[i];
            }
            Array.Sort(array);

            for (int i = 0; i < length; i++)
            {

                bool a = char.IsUpper(array[i]);

                if (a == true)
                {
                    serial += array[i];
                }

            }

                Console.WriteLine("\n" + serial + "\n");
                Console.ReadLine();
            }

        }
}
