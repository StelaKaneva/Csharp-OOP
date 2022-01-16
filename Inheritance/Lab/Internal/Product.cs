using System;
using System.Collections.Generic;
using System.Text;

namespace Internal
{
    public class Product
    {
        public int Id { get; set; }
        protected int Price { get; set; }
        internal string Name { get; set; }
    }
}
