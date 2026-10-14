class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 1.0;
    }

    public Circle(double radius)
    {
        SetRadius(radius);
        
        // this.SetRadius(radius)
        // ^also works. Need method as general class function, not set to a specific instance.
    }

    private void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return _radius * _radius * 3.14159;
    }


}