using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Worker
    {
        public abstract decimal Salary { get; set; }
        public abstract void Work();
       
        public void Slack()// Всеки 1 worker slack-ва по 1 и същи начин
        {
            Console.WriteLine("Slacking is cool!");
        }
    }
}
