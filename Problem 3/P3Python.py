class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        lastIndex = {}
        L = 0
        best = 0

        for R in range(len(s)):
            if s[R] in lastIndex and lastIndex[s[R]] >= L:
                L = lastIndex[s[R]] + 1

            lastIndex[s[R]] = R
            best = max(best, R - L + 1)

        return best
        