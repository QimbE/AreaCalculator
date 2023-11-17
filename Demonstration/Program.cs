// See https://aka.ms/new-console-template for more information

using SurfaceCalc;


List<ISurfaceCalculatable> shapes = new()
{
    new Circle(10),
    new Triangle(3,4,5)
};

foreach (ISurfaceCalculatable shape in shapes)
{
    Console.WriteLine($"{shape.GetType().Name} surface is equal to {shape.CalculateSurface()}");
}