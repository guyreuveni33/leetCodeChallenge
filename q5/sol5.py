from typing import List
class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        result = []
        i, k = 0, len(nums) - 1
        while i < len(nums) - 2:  # Ensure there are at least 3 elements
            k = len(nums) - 1  # Reset `k` for each `i`
            j = i + 1
            while j < k:
                if nums[i] + nums[j] + nums[k] == 0:
                    result.append([nums[i], nums[j], nums[k]])
                    while j < k and nums[j] == nums[j + 1]:
                        j += 1
                    while j < k and nums[k] == nums[k - 1]:
                        k -= 1
                    j += 1
                    k -= 1
                elif nums[i] + nums[j] + nums[k] < 0:
                    j += 1
                else:
                    k -= 1
            while i < len(nums) - 2 and nums[i] == nums[i + 1]:
                i += 1
            i += 1
        return result


sol = Solution()
print(sol.threeSum([-1,0,1,2,-1,-4,-2,-3,3,0,4]))
