using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class QuickSort : IStrategy
    {
        public void Sort(int[] NumberList)
        {
            int first = 0;
            int Last = NumberList.Length - 1;
            int [] NumberSorted = quicksort(NumberList, first, Last);
            Console.WriteLine("QuickSort!!!");
            Console.WriteLine("[{0}]", string.Join(", ", NumberSorted));
        }

        int [] quicksort(int[] NumberList, int first, int last)
        {
            if (first >= last)
                return null;
            int q = partition(NumberList, first, last);
            quicksort(NumberList, first, last - 1);
            quicksort(NumberList, first + 1, last);
            return NumberList;
        }
        private int partition(int[] numberList, int first, int last)
        {
            int x = numberList[last];
            int i = first - 1;
            for (int j = first; j < last; ++j)
            {
                if (numberList[j] <= x)
                {
                    ++i;
                    int temp = numberList[i];
                    numberList[i] = numberList[j];
                    numberList[j] = temp;
                }
            }
            ++i;
            int temp2 = numberList[i];
            numberList[i] = numberList[last];
            numberList[last] = temp2;
            return i;
        }

    }
}
