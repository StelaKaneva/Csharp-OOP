using InterfacesAndAbstraction.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstraction
{
    public class Store
    {
        public void BuyProduct(IPrice product, User user)
        {
            decimal price = product.Price;
            if (user.Money < price)
            {
                throw new ArgumentException("Nyama cash");
            }

            user.Money -= price;
            Console.WriteLine($"Bought " + product + $" for only: {price}");
        }

        //public void BuyShoe(Shoe shoe, User user)
        //{
        //    decimal price = shoe.Price;
        //    if (user.Money < price)
        //    {
        //        throw new ArgumentException("Nyama cash");
        //    }

        //    user.Money -= price;
        //}
    }
}
