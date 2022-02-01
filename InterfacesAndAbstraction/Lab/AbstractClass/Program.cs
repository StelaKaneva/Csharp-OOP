using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Programmer();
            worker.Slack();
            worker.Work();
        }
    }
}
