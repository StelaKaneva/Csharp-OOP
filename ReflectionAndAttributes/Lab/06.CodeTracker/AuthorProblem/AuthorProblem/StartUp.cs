using System;
using System.Reflection;

namespace AuthorProblem
{
    [Author("Stoyan")]
    public class StartUp
    {
        [Author("Pesho")]
        public static void Main(string[] args)
        {
            //var allTypes = Assembly.GetExecutingAssembly().GetTypes();

            //foreach (var item in allTypes)
            //{
            //    var attrs = item.GetCustomAttributes(typeof(AuthorAttribute));

            //    foreach (var att in attrs)
            //    {
            //        Console.WriteLine(item.Name + " " + ((AuthorAttribute)att).Name);
            //    }
            //}

            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
