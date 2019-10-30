using System;

namespace ClassLibrary1
{
    public class Calcoli
    {
        public static int mistero1(int x, int y)
        {
            int prec;
            if (y == 0)
            {
                return x;
            }
            else
            {
                prec = mistero1(x, y - 1) + 1;
                return prec;
            }
        }

    }
}
