using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class LionCat : Cat
    {
        const int LION_CAT_AVERAGE_HEIGHT = 1100;
        const string LION_CAT_SOUND = "Roar!!!!";
        public LionCat()
        {
            AverageHeight = LION_CAT_AVERAGE_HEIGHT;
        }
        public override string Eat()
        {
            return LION_CAT_SOUND;
        }
    }
}
