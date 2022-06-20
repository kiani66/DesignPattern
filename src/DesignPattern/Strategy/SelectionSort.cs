using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class SelectionSort : IStrategy
    {
        public void Sort(int [] Numbers)
        {
            int i, j, minIndex, tmp;
            int n = Numbers.Length;
            for (i = 0; i < n - 1; i++)
            {
                minIndex = i;
                for (j = i + 1; j < n; j++)
                    if (Numbers[j] < Numbers[minIndex])
                        minIndex = j;
                if (minIndex != i)
                {
                    tmp = Numbers[i];
                    Numbers[i] = Numbers[minIndex];
                    Numbers[minIndex] = tmp;
                }
            }
            Console.WriteLine("SelectionSort!!!");
            Console.WriteLine("[{0}]", string.Join(", ", Numbers));
        }
    }
}
