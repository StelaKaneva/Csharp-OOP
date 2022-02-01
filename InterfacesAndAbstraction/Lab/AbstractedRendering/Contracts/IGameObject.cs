using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractedRendering.Contracts
{
    public interface IGameObject
    {
        void Draw(IDrawer drawer);
    }
}
