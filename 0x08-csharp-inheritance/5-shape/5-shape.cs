using System;

/// <summary>
/// Empty class representing a geometric shape.
/// </summary>
class Shape
{
    /// <summary>
    /// Calculates the area of this shape.
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
