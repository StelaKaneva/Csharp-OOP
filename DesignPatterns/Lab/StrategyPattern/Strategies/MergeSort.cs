using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies
{
    public class MergeSort : ISortingStrategy
    {
        public void Sort(List<int> collection)
        {
            Console.WriteLine("Merge sort");
        }
    }
}
