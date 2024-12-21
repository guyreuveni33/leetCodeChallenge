class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        length, flag = 0, 0
        l = len(s) - 1
        # s=s.rstrip()
        while l >= 0:
            if s[l] == " ":
                l -= 1
            else:
                break
        for char in s[l::-1]:
            if char == " ":
                return length
            length += 1
        return length


sol = Solution()
print(sol.lengthOfLastWord("Hello World"))
