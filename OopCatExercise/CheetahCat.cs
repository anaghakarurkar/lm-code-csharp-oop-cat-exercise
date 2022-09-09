using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        private const string CHEETAH_CAT_SOUND = "Zzzzzzz";
        public override string Eat()
        {
            return CHEETAH_CAT_SOUND;
        }
    }
}
