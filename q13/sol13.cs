public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        HashSet<char> jewelsHash=jewels.ToHashSet();
        int counter=0;
        foreach (char stone in stones){
            if(jewelsHash.Contains(stone)){
                counter++;
            }
        }
        return counter;
    }}
    
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