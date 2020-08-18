using System;
using System.Linq;

/// <summary>
/// Provides type checking behavior.
/// </summary>
class Obj
{
    /// <summary>
    /// Determines whether of not an object is an Array or derived from Array.
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
