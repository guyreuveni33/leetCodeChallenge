from typing import List


class Solution:
    def shortestCompletingWord(self, licensePlate: str, words: List[str]) -> str:
        hash_table = {}
        words = sorted(words, key=len)
        for i in range(len(licensePlate)):
            if (licensePlate[i].isalpha()):
                if licensePlate[i].lower() not in hash_table:
                    hash_table[licensePlate[i].lower()] = 0
                hash_table[licensePlate[i].lower()] += 1
        print(hash_table)
        for word in words:
            flag = 0
            temp_hash = hash_table.copy()
            for i in range(len(word)):
                if word[i].isalpha():
                    if word[i].lower() in temp_hash:
                        temp_hash[word[i].lower()] -= 1
                        print(temp_hash)
            for item in temp_hash:
                if temp_hash[item] > 0:
                    flag = 1
                    break
            if flag == 0:
                return word


# Example inputs
licensePlate = "1s3 PSt"
words = ["step", "steps", "stripe", "stepple"]

sol = Solution()
result = sol.shortestCompletingWord(licensePlate, words)
