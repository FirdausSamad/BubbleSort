using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is Bubble sort program.
            int[] list = new int[] { 20, 1, 3, 2, 10, 7 };
            int temp;
            for (int k = 0; k < list.Length; k++)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (i != list.Length - 1 && (list[i] > list[i + 1]))
                    {
                        temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
            }
            foreach(int a in list)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
