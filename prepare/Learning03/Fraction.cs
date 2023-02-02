class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        this._top = 1;
        this._bottom = 1;
    }

    public Fraction(int top)
    {
        this._top = top;
        this._bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        this._top = top;
        this._bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{this._top}/{this._bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)this._top / (double)this._bottom;
    }

    // Getters and Setters for my private attributes
    public int getTop() { return this._top; }
    public void setTop(int n) { this._top = n; }
    public int getBottom() { return this._bottom; }
    public void setBottom(int n) { this._bottom = n; }
}