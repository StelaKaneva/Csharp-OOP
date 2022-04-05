using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    [Serializable]
    public class City : ICloneable
    {
        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
