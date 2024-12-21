class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        for bracket in s:
            if bracket in ["[", "{", "("]:
                stack.append(bracket)
            elif not stack:
                return False
            else:
                if stack[-1] == "[" and bracket != "]":
                    return False
                elif stack[-1] == "{" and bracket != "}":
                    return False
                elif stack[-1] == "(" and bracket != ")":
                    return False
                else:
                    stack.pop()
        if not stack:
            return True
        else:
            return False


sol = Solution()
sol.isValid("(]")
