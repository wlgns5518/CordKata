using System;
using System.Linq;

public class Solution {
    public int[] solution(int brown, int yellow)
{
    for (int height = 1; height <= Math.Sqrt(yellow); height++)
    {
        if (yellow % height != 0) continue;
        int width = yellow / height;

        int totalWidth = width + 2;
        int totalHeight = height + 2;
        int brownCount = (totalWidth * 2) + (totalHeight * 2) - 4;

        if (brownCount == brown)
        {
            // 가로가 세로보다 크거나 같아야 하므로 내림차순 정렬
            return new int[] { totalWidth, totalHeight };
        }
    }
    return new int[0]; // 조건에 맞는 경우가 없을 때
}
}