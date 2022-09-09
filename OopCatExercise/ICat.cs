using System;
namespace OopCatExercise
{
    public interface ICat
    {
        string Eat();
        void Sleep()
        {
            Console.WriteLine("Cat Sleeping....");
        }

    }
}
