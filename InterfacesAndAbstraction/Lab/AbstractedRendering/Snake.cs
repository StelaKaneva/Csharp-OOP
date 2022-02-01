using AbstractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractedRendering
{
    public class Snake : IGameObject
    {
        public void Draw(IDrawer drawer)
        {
            drawer.WriteLine("Az sym zmiyata");
        }
    }
}
