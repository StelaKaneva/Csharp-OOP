using System;

namespace Interfaces_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Workers.Add(new Programmer());
            company.Workers.Add(new FactoryMan());
            company.Workers.Add(new Boss());
            company.Workers.Add(new Boss());
            company.Workers.Add(new Intern());

            while (true)
            {
                var input = Console.ReadLine();

                company.WorkDay();

                if (input == "Salary")
                {
                    company.SalaryDay();
                }
            }
        }
    }
}
