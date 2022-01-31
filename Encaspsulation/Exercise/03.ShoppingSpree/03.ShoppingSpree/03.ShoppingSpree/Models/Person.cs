using System;
using System.Collections.Generic;

using _03.ShoppingSpree.Common;

using System.Text;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private const string NOT_ENOUGH_MONEY_MSG = "{0} can't afford {1}";
        private const string SUCC_BOUGHT_PRODUCT_MS = "{0} bought {1}";

        private string name;
        private decimal money;
        private readonly ICollection<Product> bag;

        private Person()
        {
            //Only initialize the list
            this.bag = new List<Product>();
        }

        public Person(string name, decimal money) 
            : this()
        {
            //this.bag = new List<Product>();
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.EMPTY_NAME_EXC_MSG);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.NEGATIVE_MONEY_EXC_MSG);
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag
        {
            get
            {
                return (IReadOnlyCollection<Product>)this.bag;
            }
        }

        public string BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                return String.Format(NOT_ENOUGH_MONEY_MSG, this.Name, product.Name);
            }

            this.Money -= product.Cost;
            this.bag.Add(product);
            return String.Format(SUCC_BOUGHT_PRODUCT_MS, this.Name, product.Name);
        }

        public override string ToString()
        {
            string productsOutput = this.Bag.Count > 0 ? String.Join(", ", this.Bag) : "Nothing bought";
            
            return $"{this.Name} - {productsOutput}";
        }
    }
}
