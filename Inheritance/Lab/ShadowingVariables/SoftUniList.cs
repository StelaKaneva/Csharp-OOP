using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowingVariables
{
    public class SoftUniList<T> : List<T> //SoftUniList : List<string> - T винаги ще е лист от string
    {
        public void Add(T item)
        {
            Console.WriteLine("Adding " + item);
            base.Add(item);
        }
    }
}
