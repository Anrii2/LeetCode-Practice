public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var map = new Dictionary<char, int>();
        int L = 0;
        int best = 0;

        for (int R = 0; R < s.Length; R++) {
            char c = s[R];

            if (map.ContainsKey(c) && map[c] >= L) {
                L = map[c] + 1;
            }

            map[c] = R;
            best = Math.Max(best, R - L + 1);
        }

        return best;
    }
}