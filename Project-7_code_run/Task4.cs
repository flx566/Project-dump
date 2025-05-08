using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        long[,] dp = new long[n, m];
        dp[0, 0] = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i - 2 >= 0 && j - 1 >= 0)
                    dp[i, j] += dp[i - 2, j - 1];
                if (i - 1 >= 0 && j - 2 >= 0)
                    dp[i, j] += dp[i - 1, j - 2];
            }
        }

        Console.WriteLine(dp[n - 1, m - 1]);
    }
}