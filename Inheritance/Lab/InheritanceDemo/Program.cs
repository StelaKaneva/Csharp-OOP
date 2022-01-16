using System;

namespace InheritanceDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Worker worker = new Worker();
            //worker.Name = "Pesho";
            //Console.WriteLine(worker.Name);
            //worker.Sleep();

            //FactoryWorker workerInFactory = new FactoryWorker();
            //workerInFactory.Name = "Gosho";
            //worker.Eat();

            FactoryWorker worker = new FactoryWorker();
            FactoryWorker worker1 = new FactoryWorker("BMW");
        }
    }
}
