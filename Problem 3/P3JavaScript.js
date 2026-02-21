/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    let map = new Map();
    let L = 0;
    let best = 0;

    for (let R = 0; R<s.length; R++){
        const c = s[R];

        if (map.has(c) && map.get(c) >= L) {
            L = map.get(c) + 1;
        }
        map.set(c, R);
        best = Math.max(best, R - L + 1);
    }
    return best;
    
};