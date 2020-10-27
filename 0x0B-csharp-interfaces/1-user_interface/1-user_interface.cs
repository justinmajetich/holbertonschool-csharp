using System;

/// <summary>
/// 
/// </summary>
abstract class Base {

    public string name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString() {
        return $"{name} is a {this.GetType()}";
    }

}

class TestObject : Base, IInteractive, IBreakable, ICollectable {

    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact() {
        throw new NotImplementedException();
    }

    public void Break() {
        throw new NotImplementedException();
    }

    public void Collect() {
        throw new NotImplementedException();
    }

}

/// <summary>
/// 
/// </summary>
public interface IInteractive {

    /// <summary>
    /// 
    /// </summary>
    void Interact();

}

/// <summary>
/// 
/// </summary>
public interface IBreakable {

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    int durability { get; set; }

    /// <summary>
    /// 
    /// </summary>
    void Break();

}

/// <summary>
/// 
/// </summary>
public interface ICollectable {

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    bool isCollected { get; set; }

    /// <summary>
    /// 
    /// </summary>
    void Collect();

}