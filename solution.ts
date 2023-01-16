function minWindow(s: string, t: string): string {
    let map: any = {};
    t.split('').forEach(ch => map[ch] = (map[ch] || 0) + 1);
    let count = Object.keys(map).length;
}