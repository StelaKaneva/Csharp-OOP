using System;

namespace LazyInitialization
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Lazy<Cart> cart = new Lazy<Cart>(() => new Cart("Starting Shopping"));
            //Lazy<Cart> cart = new Lazy<Cart>(); - bez param
            Console.WriteLine("In main");

            cart.Value.Balance = 50; // cart.Value e samiyat obekt
            Console.WriteLine(cart.Value.Balance);
        }
    }
}
