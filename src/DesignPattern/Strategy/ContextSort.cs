using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
     class ContextSort
    {
        private IStrategy _strategy;
        private int[] Numbers;
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void setnumbers(int[] numbers)
        {
            Numbers = numbers;
        }
        public void SortNumers()
        {
            _strategy.Sort(Numbers);
        }
    }
}
