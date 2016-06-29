namespace Shapes.InnitialShapes
{
    public class Square : Rectangle
    {
        public Square(double width) : base(width, 0)
        {

        }

        public override double CalculateSurface()
        {
            return (Width * Width);
        }
    }
}
