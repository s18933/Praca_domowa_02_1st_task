using System;
using System.Collections.Generic;
using System.Text;

namespace Broken
{
    class Skeleton
    {
        public string Name { get; set; }
        public string Bones { get; set; }
        public int Age { get; set; }

        public void IsAHuman() {
            if (Bones < 207 || Bones > 207) {
                Console.WriteLine("This is not a human");
            }
            else
            {
                Console.WriteLine("This is a human");
            }
        }

    }
}
