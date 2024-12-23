using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string ReorganizeString(string s)
    {
        // Step 1: Count character frequencies
        Dictionary<char, int> frequencyMap = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (frequencyMap.ContainsKey(c))
                frequencyMap[c]++;
            else
                frequencyMap[c] = 1;
        }

        // Step 2: Check if reorganization is possible
        int n = s.Length;
        int maxFrequency = frequencyMap.Values.Max();
        if (maxFrequency > (n + 1) / 2)
        {
            return ""; // Not possible to reorganize
        }

        // Step 3: Create a max heap
        PriorityQueue<(char, int), int> maxHeap = new PriorityQueue<(char, int), int>();
        foreach (var kvp in frequencyMap)
        {
            maxHeap.Enqueue((kvp.Key, kvp.Value), -kvp.Value); // Max heap
        }

        // Step 4: Build the result
        string result = "";
        (char prevChar, int prevCount) = ('#', 0); // Placeholder for previous character

        while (maxHeap.Count > 0)
        {
            var (currentChar, currentCount) = maxHeap.Dequeue();
            result += currentChar;

            // If the previous character still has a count, add it back to the heap
            if (prevCount > 0)
            {
                maxHeap.Enqueue((prevChar, prevCount), -prevCount);
            }

            // Update prevChar and prevCount
            prevChar = currentChar;
            prevCount = currentCount - 1;
        }

        return result;
    }
}