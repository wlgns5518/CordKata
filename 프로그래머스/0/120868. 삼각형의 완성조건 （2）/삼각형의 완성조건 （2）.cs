using System;
using System.Linq;
public class Solution {
    public int solution(int[] sides)
{
    int x = sides[0];
    int y = sides[1];
    return x + y - 1 - Math.Abs(x - y);
}
}