using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] lines) {
        List<int> points = new List<int>();

        // 모든 선분의 좌표를 리스트에 추가
        for (int i = 0; i < 3; i++) {
            for (int j = lines[i, 0]; j < lines[i, 1]; j++) {
                points.Add(j);
            }
        }

        // 중복된 좌표 개수 찾기
        return points.GroupBy(x => x).Count(g => g.Count() > 1);
    }
}