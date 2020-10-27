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
