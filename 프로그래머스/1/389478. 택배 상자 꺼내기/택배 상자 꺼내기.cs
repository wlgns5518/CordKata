using System;

public class Solution {
    public int solution(int n, int w, int num) {
    int[] height = new int[w];

    // 각 열별로 박스 개수 채우기
    for (int i = 0; i < n; i++) {
        int row = i / w;
        int col = (row % 2 == 0) ? i % w : (w - 1 - (i % w));
        height[col]++;
    }

    // num 위치 찾기
    int idx = num - 1;
    int rowNum = idx / w;
    int colNum = (rowNum % 2 == 0) ? (idx % w) : (w - 1 - (idx % w));

    // 해당 열에 총 몇 개 쌓였는지 - (num이 몇 번째 행인지) = 위에 몇 개 남아있는지
    int answer = height[colNum] - rowNum;

    return answer;
}
}