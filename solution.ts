let left = 0;
    let right = 0;
    let head = 0;
    let len = Infinity;

    while (right < s.length) {
        let r = s[right];
        if (map[r] !== undefined) {
            map[r]--;
            if (map[r] === 0) count--;
        }
        right++;
    }