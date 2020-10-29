using System;

delegate void CalculateHealth(float value);

/// <summary>
/// A delegate used to calculate modifiers.
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// An enumeration of modifiers for enemy attacks.
/// </summary>
public enum Modifier {
    /// <summary>The weak modifier.</summary>
    Weak,
    /// <summary>The base modifier.</summary>
    Base,
    /// <summary>The strong modifier.</summary>
    Strong
}

class CurrentHPArgs : EventArgs {

    public float currentHp { get; }

    /// <summary>
    /// Constructor method.
    /// </summary>
    public CurrentHPArgs(float newHp) {
        this.currentHp = newHp;
    }

}

/// <summary>
/// Represents a player.
/// </summary>
public class Player
{
    string name { get; set; }
    float maxHp { get; set; }
    float hp { get; set; }
    string status { get; set; }

    event EventHandler<CurrentHPArgs> HPCheck; 

    /// <summary>
    /// Constructor for player object.
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f) {
        this.name = name;

        if (maxHp > 0) {
            this.maxHp = maxHp;
        } else {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;

        this.status = $"{name} is ready to go!";

        HPCheck += CheckStatus;
    }

    private void CheckStatus(object sender, CurrentHPArgs e) {

        if (e.currentHp == maxHp) {
            Console.WriteLine($"{name} is in perfect health!");
        } else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp) {
            Console.WriteLine($"{name} is doing well!");
        } else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2) {
            Console.WriteLine($"{name} isn't doing too great...");
        } else if (e.currentHp > 0 && e.currentHp < maxHp / 4) {
            Console.WriteLine($"{name} needs help!");
        } else {
            Console.WriteLine($"{name} is knocked out!");
        }

    }

    /// <summary>
    /// Applies damage to player.
    /// </summary>
    public void TakeDamage(float damage) {

        if (damage >= 0) {
            Console.WriteLine($"{name} takes {damage} damage!");
        } else {
            Console.WriteLine($"{name} takes 0 damage!");
        }

        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Rejuvinates player HP.
    /// </summary>
    public void HealDamage(float heal) {

        if (heal >= 0) {
            Console.WriteLine($"{name} heals {heal} HP!");
        } else {
            Console.WriteLine($"{name} heals 0 HP!");
        }

        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Apply modifier to incoming damage.
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier) {

        if (modifier == Modifier.Weak) {
            return baseValue / 2;
        }
        else if (modifier == Modifier.Base) {
            return baseValue;
        }
        else {
            return baseValue * 1.5f;
        }
    }

    /// <summary>
    /// Validates player's new HP.
    /// </summary>
    public void ValidateHP(float newHp) {

        if (newHp < 0 ) {
            newHp = 0;
        }
        if (newHp > maxHp) {
            newHp = maxHp;
        }

        hp = newHp;

        HPCheck.Invoke(this, new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Prints the health of the player.
    /// </summary>
    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

}
