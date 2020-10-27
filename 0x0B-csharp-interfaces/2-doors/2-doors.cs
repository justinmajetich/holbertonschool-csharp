using System;

/// <summary>
/// 
/// </summary>
class Door : Base, IInteractive {

    public Door(string _name = "Door") {
        name = _name;
    }

    public void Interact() {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }

}

/// <summary>
/// A base class.
/// </summary>
abstract class Base {

    public string name { get; set; }

    /// <summary>
    /// Convert the object to a string.
    /// </summary>
    public override string ToString() {
        return $"{name} is a {this.GetType()}";
    }

}

/// <summary>
/// Interface defining an interactable object.
/// </summary>
public interface IInteractive {

    /// <summary>
    /// Interact with this object.
    /// </summary>
    void Interact();

}

/// <summary>
/// Interface defining a breakable object.
/// </summary>
public interface IBreakable {

    /// <summary>
    /// The durability of the breakable object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Break this object.
    /// </summary>
    void Break();

}

/// <summary>
/// Interface defining a collectable object.
/// </summary>
public interface ICollectable {

    /// <summary>
    /// Denotes whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect this object.
    /// </summary>
    void Collect();

}