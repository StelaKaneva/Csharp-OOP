using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {
        private const string INVALID_SIDE_EXC_MSG = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Height = height;
            this.Width = width;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.ValidateSide(value, nameof(Height));

                this.height = value;
            }
        }

        public double CalculateSurfaceArea() => 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;

        public double CalculateLateralSurfaceArea() => 2 * this.Length * this.Height + 2 * this.Width * this.Height;

        public double CalculateVolume() => this.Length * this.Height * this.Width;

        private void ValidateSide(double side, string paramName)
        {
            if (side <= 0)
            {
                //throw new ArgumentException($"{paramName} cannot be zero or negative.");
                throw new ArgumentException(String.Format(INVALID_SIDE_EXC_MSG, paramName));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.CalculateSurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.CalculateLateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {this.CalculateVolume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
