using System;
using System.Collections.Generic;
using System.Text;


namespace OopCatExercise
{
    public class DomesticCat : Cat
    {

        const int DOMESTIC_CAT_HEIGHT = 23;
        const string DOMESTIC_CAT_SOUND = "Purrrrrrr";
        public DomesticCat()
        {
            IsAsleep = false;

            AverageHeight = DOMESTIC_CAT_HEIGHT;

            Setting = Type.Domestic.ToString().ToLower();
        }

        public override string Eat()
        {
            return DOMESTIC_CAT_SOUND;
        }

    }
}
