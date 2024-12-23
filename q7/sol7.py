from typing import List


class Solution:
    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        intervals.sort(key=lambda x: x[0])
        l = len(intervals)
        i = 0
        while i < l - 1:
            if intervals[i][0] <= intervals[i + 1][0]:
                if intervals[i][1] >= intervals[i + 1][0]:
                    intervals[i][1] = max(intervals[i][1], intervals[i + 1][1])
                    intervals.pop(i + 1)
                    l -= 1
                else:
                    i += 1
        return intervals


sol = Solution()
print(sol.merge([[1, 3], [2, 6], [8, 10], [15, 18]]))
