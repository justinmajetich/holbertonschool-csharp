using System;

/// <summary>
/// Represents a square
/// </summary>
class Square : Rectangle
{
    private int size;

    public int Size {
        get => size;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = value;
                Width = value / 2;
                Height = value / 2;
            }
        }
    }
}

/// <summary>
/// Represents a rectangle
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width {
        get => width; 
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    public int Height {
        get => height; 
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }

    /// <summary>
    /// Calculate area of rectangle object.
    /// </summary>
    public new int Area()
    {
        return Width * Height;
    }

    /// <summary>
    /// Provides a string representation of the instance.
    /// </summary>
    public override string ToString()
    {
        return $"[Rectangle] {Width} / {Height}";
    }
}

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
