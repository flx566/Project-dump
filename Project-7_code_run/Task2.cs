using System;

class Program
{
    static void Main()
    {
        int[] values = { 0, 1, -5 };

        foreach (int x in values)
        {
            int y;
            if (x < 0)
                y = -x;
            else if (x == 0)
                y = 0;
            else
                y = x;

            Console.WriteLine(y);
        }
    }
}