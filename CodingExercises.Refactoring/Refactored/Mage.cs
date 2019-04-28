using System;

namespace CodingExercises.Refactoring.Refactored
{
    public class Mage : Player
    {
        public override int Attack()
        {
            return CastSpell();
        }

        private int CastSpell()
        {
            // code review: DateTime.UtcNow may be faster for this use case
            // https://blogs.msdn.microsoft.com/kirillosenkov/2012/01/10/datetime-utcnow-is-generally-preferable-to-datetime-now/
            return DateTime.Now.Millisecond % 20;
        }

        public override bool CanWearArmor()
        {
            return false;
        }
    }
}
