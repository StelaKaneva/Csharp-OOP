using System;

namespace InterfacesAndAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            User user = new User();
            user.Money = 500;
            store.BuyProduct(new Shoe() { Price = 55 }, user);
            store.BuyProduct(new Toothbrush() { Price = 100 }, user);
        }
    }
}
