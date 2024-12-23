using System;

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int prev1 = 0; // dp[i-1]
        int prev2 = 0; // dp[i-2]

        foreach (int c in cost)
        {
            int curr = c + Math.Min(prev1, prev2);
            prev2 = prev1;
            prev1 = curr;
        }

        // Minimum cost to reach the top is the smaller of the last two costs
        return Math.Min(prev1, prev2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        // Example 1
        int[] cost1 = { 10, 15, 20 };
        Console.WriteLine($"Example 1 Output: {sol.MinCostClimbingStairs(cost1)}"); // Expected: 15

        // Example 2
        int[] cost2 = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
        Console.WriteLine($"Example 2 Output: {sol.MinCostClimbingStairs(cost2)}"); // Expected: 6
    }
}