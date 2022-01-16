using System;

namespace ShadowingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            TennisEvent tennisEvent = new TennisEvent();
            tennisEvent.Print(); //презаписваме базовия Duration. Само вътре в класа имаме достъп до него.
            Console.WriteLine(tennisEvent.Duration);
            tennisEvent.Start();
            Console.WriteLine(tennisEvent);

            SoftUniList<int> list = new SoftUniList<int>();
            list.Add(5);
            list.Add(5);
            list.Add(5);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
