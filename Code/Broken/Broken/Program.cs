using System;

namespace Broken
{
    class Program
    {
        static void Main(string[] args)
        {
            Skeleton skeleton = new Skeleton();

            skeleton.Name = "Rozitta";
            skeleton.Age = 60;
            skeleton.Bones = 207;

            skeleton.IsAHuman();
        }
    }
}
