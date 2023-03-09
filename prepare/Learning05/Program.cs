class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 4));
        shapes.Add(new Rectangle("green", 2, 4));
        shapes.Add(new Circle("blue", 2));

        shapes.ForEach(shape =>
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        });
    }
}