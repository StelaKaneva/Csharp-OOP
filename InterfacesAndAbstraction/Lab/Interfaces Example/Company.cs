using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Example
{
    public class Company
    {
        public List<IWorker> Workers { get; set; }

        public Company()
        {
            Workers = new List<IWorker>();
        }

        public void WorkDay()
        {
            Workers.ForEach((worker) =>
            {
                if (worker is Programmer)
                {
                    //Programmer programmer = (Programmer)worker;
                    Console.WriteLine("Programist");
                }
                worker.Work();
            });
        }

        public void SalaryDay()
        {
            Workers.ForEach((worker) =>
            {
                worker.GetSalary();
            });
        }
    }
}
