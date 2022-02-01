using AbstractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractedRendering
{
    public class Obstacle : IGameObject
    {
        public void Draw(IDrawer drawer)
        {
            drawer.WriteLine("Obstacle na pytya");
        }
    }
}
