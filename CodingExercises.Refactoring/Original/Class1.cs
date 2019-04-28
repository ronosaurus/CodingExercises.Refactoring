using System;

namespace CodingExercises.Refactoring.Original
{
    public enum PlayerClass
    { 
        Warrior,
        Mage,
        Archer
    }

    public class Armor
    {
        public bool IsLight { get; set; }
    }

    /// <summary>
    /// Defines a Player. A Player can attack and wear armor
    /// </summary>
    public class Player
    { 
        public Armor Armor { get; set; }

        /// <summary>
        /// Attack another player
        /// </summary>
        /// <param name="playerClass">The <see cref="PlayerClass"/>attacking</param>
        /// <returns>An int representing the amount of damage caused</returns>
        public int Attack(PlayerClass playerClass)
        {
            switch (playerClass)
            {
                case PlayerClass.Warrior:
                    return SwingSword();
                case PlayerClass.Mage:
                    return CastSpell();
                case PlayerClass.Archer:
                    return ShootArrow();
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Check if the player can wear armor
        /// </summary>
        /// <param name="playerClass">The <see cref="PlayerClass"/></param>
        /// <returns>Returns true if the player can wear armor, false otherwise</returns>
        public bool CanWearArrmor(PlayerClass playerClass)
        {
            switch (playerClass)
            {
                case PlayerClass.Warrior:
                    return true;
                case PlayerClass.Mage:
                    return false;
                case PlayerClass.Archer:
                    return Armor.IsLight;
                default:
                    return false;
            }
        }

        private int SwingSword()
        {
            var x = new Random(1000);
            return x.Next() % 10;
        }
        
        private int CastSpell()
        {
            return DateTime.Now.Millisecond % 20;
        }

        private int ShootArrow()
        {
            return DateTime.Now.Millisecond % 10;
        }
    }
}