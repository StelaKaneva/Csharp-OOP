using System;

namespace PrototypePattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Country country = new Country() { Name = "Bulgaria" };
            City city = new City() { Name = "Plovdiv"};
            Address address = new Address() { Street = "Sveta troica 29" };

            address.City = city;
            address.Country = country;

            Address prototypeAdress = (Address)address.Clone();
            prototypeAdress.Street = "Aleksandur Batenberg 1";
            prototypeAdress.City.Name = "Sofia"; //tova shte gi promeni i na 2-te mesta. Пример за Shallow Copy - Fiksva se, kato implementirame navsyakyde ICloneable

            Console.WriteLine(address);
            Console.WriteLine(prototypeAdress);
        }
    }
}
