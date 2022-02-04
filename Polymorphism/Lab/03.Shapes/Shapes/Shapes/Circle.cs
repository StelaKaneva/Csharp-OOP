using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius cannot be zero or negative.");
                }

                this.radius = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.Pow(this.Radius, 2) * Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Radius * Math.PI;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
