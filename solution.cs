Here is a JavaScript solution for the problem:

```javascript
function minWindow(s, t) {
    let map = {};
    t.split('').forEach(ch => map[ch] = (map[ch] || 0) + 1);
    let count = Object.keys(map).length;
    let left = 0;
    let right = 0;
    let minLen = Infinity;
    let minStr = '';

    while(right < s.length) {
        let rightChar = s[right];
        if(map[rightChar] !== undefined) map[rightChar]--;
        if(map[rightChar] === 0) count--;
        while(count === 0) {
            if(right - left < minLen) {
                minLen = right - left;
                minStr = s.slice(left, right + 1);
            }
            let leftChar = s[left];
            if(map[leftChar] !== undefined) map[leftChar]++;
            if(map[leftChar] > 0) count++;
            left++;
        }
        right++;
    }
    return minStr;
}

console.log(minWindow("ADOBECODEBANC", "ABC"));
```

This console application uses the sliding window technique to find the minimum window substring that contains all characters of another string. It first creates a map of all characters in the target string and their counts. Then it uses two pointers, left and right, to traverse the source string. When it finds a character that is in the map, it decreases its count in the map. When the count of a character in the map is zero, it means all occurrences of this character in the target string are found in the current window. It then tries to minimize the window by moving the left pointer. When a character is moved out of the window, if its count in the map is greater than zero, it means not all occurrences of this character in the target string are found in the current window. So it increases the count and continues to move the right pointer. The process repeats until the right pointer reaches the end of the source string. The minimum window substring is kept in the minStr variable.