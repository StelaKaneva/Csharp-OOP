using FactoryMethod.Contracts;
using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IAnimalFactory
    {
        public Carnivore GetCarnivore();

        public IVegan GetVegan();

        public IBug GetBug();
    }
}
