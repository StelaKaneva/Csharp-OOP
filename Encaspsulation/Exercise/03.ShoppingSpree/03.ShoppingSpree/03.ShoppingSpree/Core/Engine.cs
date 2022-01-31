using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.ShoppingSpree.Core
{
    public class Engine
    {
        //Read data from the console
        //Process data
        //Print data on the console

        private readonly ICollection<Person> people;
        private readonly ICollection<Product> products;

        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            //Place business logic here

            try
            {
                this.ParsePeopleInput();

                this.ParseProductsInput();

                string command;

                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string personName = cmdArgs[0];
                    string productName = cmdArgs[1];

                    Person person = this.people.FirstOrDefault(p => p.Name == personName);
                    Product product = this.products.FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        string result = person.BuyProduct(product);

                        Console.WriteLine(result);
                    }
                }

                foreach (Person person in this.people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
            
        }

        private void ParsePeopleInput()
        {
            string[] peopleArgs = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string personString in peopleArgs)
            {
                string[] personArgs = personString.Split("=").ToArray();

                string personName = personArgs[0];
                decimal personMoney = decimal.Parse(personArgs[1]);

                //We may have an exception

                Person person = new Person(personName, personMoney);
                this.people.Add(person);
            }
        }

        private void ParseProductsInput()
        {
            string[] productsArgs = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string productString in productsArgs)
            {
                string[] productArgs = productString.Split("=").ToArray();

                string productName = productArgs[0];
                decimal productCost = decimal.Parse(productArgs[1]);

                //We may have an exception

                Product product = new Product(productName, productCost);
                this.products.Add(product);
            }
        }
    }
}
