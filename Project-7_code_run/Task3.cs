using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var size = Console.ReadLine().Split();
        int n = int.Parse(size[0]);
        int m = int.Parse(size[1]);

        int[,] a = new int[n, m];
        int[,] dp = new int[n, m];
        char[,] from = new char[n, m];

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
                a[i, j] = int.Parse(line[j]);
        }

        dp[0, 0] = a[0, 0];

        for (int i = 1; i < n; i++)
        {
            dp[i, 0] = dp[i - 1, 0] + a[i, 0];
            from[i, 0] = 'D';
        }

        for (int j = 1; j < m; j++)
        {
            dp[0, j] = dp[0, j - 1] + a[0, j];
            from[0, j] = 'R';
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < m; j++)
            {
                if (dp[i - 1, j] > dp[i, j - 1])
                {
                    dp[i, j] = dp[i - 1, j] + a[i, j];
                    from[i, j] = 'D';
                }
                else
                {
                    dp[i, j] = dp[i, j - 1] + a[i, j];
                    from[i, j] = 'R';
                }
            }
        }

        Console.WriteLine(dp[n - 1, m - 1]);

        List<char> path = new List<char>();
        int x = n - 1, y = m - 1;
        while (x > 0 || y > 0)
        {
            path.Add(from[x, y]);
            if (from[x, y] == 'D') x--;
            else y--;
        }

        path.Reverse();
        Console.WriteLine(string.Join(" ", path));
    }
}