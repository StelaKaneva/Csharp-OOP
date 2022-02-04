using System;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape baseClass = new Rectangle() { A = 5, B = 6 };
            //Console.WriteLine(baseClass.Area());

            //baseClass = new Square() { A = 3 };
            //Console.WriteLine(baseClass.Area());

            string input = Console.ReadLine();

            while (true)
            {
                Shape baseClass = null;

                if (input == "square")
                {
                    baseClass = new Square() { A = 3 };
                }
                else if (input == "rectangle")
                {
                    baseClass = new Rectangle() { A = 5, B = 6 };
                }

                Console.WriteLine(baseClass.Area());
            }
            
        }
    }
}
