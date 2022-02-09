using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehicleExtension.IO.Contracts
{
    public interface IWritable
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
