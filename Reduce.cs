using System;

// Method to reduce the number to its first digit and return that value. 

namespace gnum
{
    public class Reduce
    {
        public static int Number(int a)
        {
            if (a < 10)
                return a;
            if (a < 100)
                return a/10;
            if (a < 1000)
                return a/100;
            else return 1;
        }
    }
}