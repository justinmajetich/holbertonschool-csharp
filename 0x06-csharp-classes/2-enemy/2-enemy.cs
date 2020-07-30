using System;

namespace Enemies
{
    /// <summary>
    /// Represents an enemy zombie
    /// </summary>
    class Zombie
    {
        /// <summary>Represents the Zombie's health points</summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with health value.
        /// </summary>
        public Zombie(int value)
        {
            if (value >= 0)
            {
                this.health = 0;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
    }
}
