using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Contracts.Factories
{
    public class EuropeFactory : IAnimalFactory
    {
        public IBug GetBug()
        {
            throw new NotImplementedException();
        }

        public Carnivore GetCarnivore()
        {
            return new EnglishMan();
        }

        public IVegan GetVegan()
        {
            throw new NotImplementedException();
        }
    }
}
