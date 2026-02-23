class Solution:
    def longestPalindrome(self, s: str) -> str:
        n = len(s)
        if n <= 1:
            return s

        best_start = 0
        best_len = 1

        def expand(l: int, r: int):
            while l >= 0 and r < n and s[l] == s[r]:
                l -= 1
                r += 1
            return l + 1, r - 1

        for i in range(n):
            l1, r1 = expand(i, i)
            if r1 - l1 + 1 > best_len:
                best_len = r1 - l1 + 1
                best_start = l1

            l2, r2 = expand(i, i + 1)
            if r2 - l2 + 1 > best_len:
                best_len = r2 - l2 + 1
                best_start = l2

        return s[best_start: best_start + best_len]
        