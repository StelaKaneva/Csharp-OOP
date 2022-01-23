using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
    
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                try
                {
                    string[] dataDog = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string name = dataDog[0];
                    int age;
                    if (!int.TryParse(dataDog[1], out age))
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    string gender = dataDog[2];


                    switch (input)
                    {
                        case "Dog":
                            Dog dog = new Dog(name, age, gender);
                            Console.WriteLine(dog);
                            break;
                        case "Cat":
                            Cat cat = new Cat(name, age, gender);
                            Console.WriteLine(cat);
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, gender);
                            Console.WriteLine(frog);
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(name, age, gender);
                            Console.WriteLine(kitten);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(name, age, gender);
                            Console.WriteLine(tomcat);
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                input = Console.ReadLine();
            }
        }
    }
}
