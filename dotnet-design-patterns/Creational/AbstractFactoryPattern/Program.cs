
using AbstractFactoryPattern;

Shape rectangle = ShapeFactory.GetShape(new RectangleFactory());
((Rectangle)rectangle).Width = 10;
((Rectangle)rectangle).Height = 5;

Shape circle = ShapeFactory.GetShape(new CircleFactory());
((Circle)circle).Radius = 4;

Console.WriteLine("Rectangle area: " + rectangle.CalculateArea() + " and size: " + rectangle.CalculateSize());
Console.WriteLine("Circle area: " + circle.CalculateArea() + " and size: " + circle.CalculateSize());