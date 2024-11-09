import math


class Solution(object):
    def judgeSquareSum(self, c):
        a, b = 0, round(math.sqrt(c))
        while a != b:
            if (a ** 2 + b ** 2) > c:
                b -= 1
            elif (a ** 2 + b ** 2) < c:
                a += 1
            else:
                return True
        if a ** 2 + b ** 2 == c:
            return True

        return False
