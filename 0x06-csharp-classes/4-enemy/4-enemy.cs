using System;

namespace Enemies
{
    /// <summary>
    /// Represents an enemy zombie
    /// </summary>
    class Zombie
    {
        // A Zombie's current health points
        private int health;
        
        // A Zombie's name
        private string name = "(No name)";

        /// <summary>Gets and sets a Zombie's name.null</summary>
        public string Name {
            get => name;
            set => name = value;
        }

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
                this.health = value;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }

        /// <summary>
        /// Gets the value of the heath property.
        /// </summary>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
