class Solution:
    def simplifyPath(self, path: str) -> str:
        components = path.split("/")
        stack = []

        for part in components:
            if part == "..":
                if stack:
                    stack.pop()
            elif part and part != ".":
                stack.append(part)
        return "/" + "/".join(stack)


sol = Solution()
print(sol.simplifyPath("/a//b////c/d//././/.."))
