using System;
using System.Reflection;

/// <summary>
/// Provides printing behavior.
/// </summary>
class Obj
{
    /// <summary>
    /// Prints all available properties and methods of an object.
    /// </summary>
    public static void Print(object myObj)
    {
        Type myType = myObj.GetType();
        PropertyInfo[] properties = myType.GetProperties();
        MethodInfo[] methods = myType.GetMethods();
        
        Console.WriteLine("{0} Properties:", myType.Name);

        foreach (var property in properties)
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("{0} Methods:", myType.Name);

        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
