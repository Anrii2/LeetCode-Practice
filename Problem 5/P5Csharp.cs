public class Solution {
    private (int start, int end) Expand(string s, int l, int r) {
        int n = s.Length;
        while (l >= 0 && r < n && s[l] == s[r]) {
            l--;
            r++;
        }
        return (l + 1, r - 1);
    }

    public string LongestPalindrome(string s) {
        int n = s.Length;
        if (n <= 1) return s;

        int bestStart = 0;
        int bestLen = 1;

        for (int i = 0; i < n; i++) {
            var (l1, r1) = Expand(s, i, i);
            int len1 = r1 - l1 + 1;
            if (len1 > bestLen) {
                bestLen = len1;
                bestStart = l1;
            }

            var (l2, r2) = Expand(s, i, i + 1);
            int len2 = r2 - l2 + 1;
            if (len2 > bestLen) {
                bestLen = len2;
                bestStart = l2;
            }
        }

        return s.Substring(bestStart, bestLen);
    }
}
