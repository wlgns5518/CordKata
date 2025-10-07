using System;

public class Solution {
    public int solution(int[] date1, int[] date2) {
        DateTime d1 = new DateTime(date1[0], date1[1], date1[2]);
        DateTime d2 = new DateTime(date2[0], date2[1], date2[2]);

        return d1 < d2 ? 1 : 0;
    }
}