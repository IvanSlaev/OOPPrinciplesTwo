namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double _width;

        private double _height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this._width; }
            internal set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative number");
                }
                this._width = value;
            }
        }

        public double Height
        {
            get { return this._height; }
            internal set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative number");
                }
                this._height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
