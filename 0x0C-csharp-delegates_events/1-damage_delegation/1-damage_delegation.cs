using System;

delegate void CalculateHealth(float value);


/// <summary>
/// Represents a player.
/// </summary>
public class Player
{
    string name { get; set; }
    float maxHp { get; set; }
    float hp { get; set; }

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

    }

    /// <summary>
    /// Prints the health of the player.
    /// </summary>
    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

}
