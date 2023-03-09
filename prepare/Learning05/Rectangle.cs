class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        this._length = length;
        this._width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}