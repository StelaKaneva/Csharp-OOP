using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Robot : IPerson
    {
        public Robot(string iD, string model)
        {
            ID = iD;
            Model = model;
        }

        public string ID { get; }
        public string Model{ get; set; }
    }
}
