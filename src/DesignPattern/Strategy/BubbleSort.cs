using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class BubbleSort : IStrategy
    {
        public void Sort(int[] NumberList)
        {
            for (int i = 0; i < NumberList.Length; i++)
            {
                for (int j = 0; j < NumberList.Length - 1; j++)
                {
                    if (NumberList[j + 1] < NumberList[j])
                    {
                        // swaping
                        int temp = NumberList[j];
                        NumberList[j] = NumberList[j + 1];
                        NumberList[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("BubbleSort!!!");
            Console.WriteLine("[{0}]", string.Join(", ", NumberList));
        }
    }
}
