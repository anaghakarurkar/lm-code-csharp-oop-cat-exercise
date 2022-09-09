using System;
using System.ComponentModel;

namespace OopCatExercise
{
    public abstract class Cat : ICat
    {
        public bool IsAsleep { get; set; }
        public double AverageHeight { get; set; }
        public string Setting { get; set; }

        public enum Type
        {
            Domestic,
            Wild
        }


        public abstract string Eat();

        public void WakeUp()
        {
            IsAsleep = false;
        }


        public void GoToSleep()
        {
            IsAsleep = true;
        }
    }
}

