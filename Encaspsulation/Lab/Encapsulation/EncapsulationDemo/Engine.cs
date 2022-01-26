using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationDemo
{
    public class Engine
    {
        private Oil oil;
        private Turbo turbo;
        private Karter karter;
        private Cilindri cillindri;

        public void Start()
        {
            oil.Use();
            turbo.Start();
        }

        public void Stop()
        {
            oil.Stop();
            turbo.Stop();
        }

        public void Accelerate()
        {

        }
    }
}
