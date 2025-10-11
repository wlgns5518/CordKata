using System;

public class Solution {
    public int solution(int[] sides) {
        Array.Sort(sides);
        if(sides[2] < sides[1] + sides[0])
            return 1;
        return 2;
    }
}