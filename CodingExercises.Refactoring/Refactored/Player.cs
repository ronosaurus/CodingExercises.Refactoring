﻿namespace CodingExercises.Refactoring.Refactored
{
    /// <summary>
    /// Defines a Player. A Player can attack and wear armor
    /// </summary>
    public abstract class Player
    {
        public Armor Armor { get; set; }

        /// <summary>
        /// Attack another player
        /// </summary>
        /// <returns>An int representing the amount of damage caused</returns>
        public virtual int Attack()
        {
            return 0;
        }

        /// <summary>
        /// Check if the player can wear armor
        /// </summary>
        /// <returns>Returns true if the player can wear armor, false otherwise</returns>
        public virtual bool CanWearArmor()
        {   
            return false;
        }
    }
}
