using System;
using System.Linq;

/// <summary>
/// Provides type checking behavior.
/// </summary>
class Obj
{
    /// <summary>
    /// Determines whether or not an object is derived of given class.
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.GetType() == baseType.GetType() && (derivedType.IsSubclassOf(baseType));
    }
}
