using System;

/// <summary>
/// Provides type checking behavior.
/// </summary>
class Obj
{
    /// <summary>
    /// Determines whether of not an object is an in.
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
