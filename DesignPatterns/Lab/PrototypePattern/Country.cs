using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    [Serializable]
    public class Country : ICloneable
    {
        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
            //return new Country() {Name = Name}; // Prawi nowo Country v pametta sys syshtiq string, no na novo myasto. Ako ne implementira ICloneable shte stane Shallow Copy - syzdawa se Country, koeto sochi kum myastoto v pametta na kloniranoto Country (referenten tip). Taka prawim Deep Copy.
        }
    }
}
