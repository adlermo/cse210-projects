class Circle : Shape
{
    private double _radius;

    public Circle(string color, double rd) : base(color)
    {
        _radius = rd;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}