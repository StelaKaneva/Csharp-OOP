using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Example
{
    public interface IManager
    {
        public List<IWorker> Team { get; set; }
    }
}
