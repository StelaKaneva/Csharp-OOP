using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver teamLead = new TeamLead();
            Approver CTO = new CTO();

            teamLead.SetNext(CTO);

            Console.WriteLine(teamLead.HandleRequest(3));
            Console.WriteLine(teamLead.HandleRequest(50));
            Console.WriteLine(teamLead.HandleRequest(5000));
        }
    }
}
