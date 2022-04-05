using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace PrototypePattern
{
    [Serializable]
    public class Address : ICloneable
    {
        public City City { get; set; }

        public Country Country { get; set; }

        public string Street { get; set; }

        public object Clone()
        {
            return DeepClone<Address>(this);


            //var clone = (Address)this.MemberwiseClone();
            //clone.City = (City)City.Clone();
            //clone.Country = (Country)Country.Clone();

            //return clone;



            //return this.MemberwiseClone();
            //new Address() { City = City, Country = Country, Street = Street };
        }

        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        public override string ToString()
        {
            return $"Country: {Country.Name} - City: {City.Name} - Street: {Street}";
        }

    }

}
