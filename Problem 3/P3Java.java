class Solution {
    public int lengthOfLongestSubstring(String s) {
        Map<Character, Integer> map = new HashMap<>();
        int L = 0;
        int best = 0;

        for (int R = 0; R < s.length(); R++) {
            char c = s.charAt(R);

            if (map.containsKey(c) && map.get(c) >= L) {
                L = map.get(c) + 1;
            }

            map.put(c, R);
            best = Math.max(best, R - L + 1);
        }

        return best;
    }
}