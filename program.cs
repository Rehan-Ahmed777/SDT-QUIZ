using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter integer values in the array: ");
            for (int i = 0; i<5; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            if ((arr[1]) >= 3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();

            }
        }
    }
