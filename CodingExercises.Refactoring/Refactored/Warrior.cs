using System;

namespace CodingExercises.Refactoring.Refactored
{
    public class Warrior : Player
    {
        public override int Attack()
        {
            return SwingSword();
        }

        private int SwingSword()
        {
            // code review: possible improvement, do not reinitialize Random on each call
            // https://stackoverflow.com/questions/19270507/correct-way-to-use-random-in-multithread-application
            // https://codeblog.jonskeet.uk/2009/11/04/revisiting-randomness/
            var x = new Random(1000);
            return x.Next() % 10;
        }

        public override bool CanWearArmor()
        {
            return true;
        }
    }
}
