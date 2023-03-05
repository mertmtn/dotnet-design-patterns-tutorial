
namespace AbstractFactoryPattern
{
    public interface Shape
    {
        public double CalculateArea();
        public double CalculateSize();
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculateSize()
        {
            return 2 * (Width + Height);
        } 
    }

    public class Circle : Shape
    {
        private double radius; 
        public double Radius { get => radius; set => radius = value; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculateSize()
        {
            return 2 * Math.PI * Radius;
        } 
    }

    public interface ShapeAbstractFactory
    {
        public Shape CreateShape();
    }
    public class CircleFactory : ShapeAbstractFactory
    {

        public Shape CreateShape()
        {
            return new Circle();
        }
    }
    public class RectangleFactory : ShapeAbstractFactory
    { 
        public Shape CreateShape()
        {
            return new Rectangle();
        }
    }

    public class ShapeFactory
    {
        public static Shape GetShape(ShapeAbstractFactory factory)
        {
            return factory.CreateShape();
        }
    }

}
