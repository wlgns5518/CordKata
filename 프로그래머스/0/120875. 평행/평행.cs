using System;

public class Solution {
    public int solution(int[,] dots)
    {
        // 두 직선의 기울기 비교를 위해 분자와 분모를 교차 곱해서 비교합니다.
        // 기울기 공식: (y2 - y1) / (x2 - x1) == (y4 - y3) / (x4 - x3)
        // 이는 다음과 같이 교차 곱으로 바꿀 수 있습니다: (y2 - y1) * (x4 - x3) == (y4 - y3) * (x2 - x1)

        // 점 (x1, y1), (x2, y2)
        int[] p1 = { dots[0, 0], dots[0, 1] };
        int[] p2 = { dots[1, 0], dots[1, 1] };

        // 점 (x3, y3), (x4, y4)
        int[] p3 = { dots[2, 0], dots[2, 1] };
        int[] p4 = { dots[3, 0], dots[3, 1] };

        // 첫 번째 직선의 기울기 (p1, p2)
        int dx1 = p2[0] - p1[0];
        int dy1 = p2[1] - p1[1];

        // 두 번째 직선의 기울기 (p3, p4)
        int dx2 = p4[0] - p3[0];
        int dy2 = p4[1] - p3[1];

        // 두 직선이 평행한지 확인 (기울기 비교)
        if (dy1 * dx2 == dy2 * dx1)
        {
            return 1;
        }

        // 4개의 점을 조합해서 다른 두 직선 비교
        // (p1, p3)와 (p2, p4)
        dx1 = p3[0] - p1[0];
        dy1 = p3[1] - p1[1];

        dx2 = p4[0] - p2[0];
        dy2 = p4[1] - p2[1];

        if (dy1 * dx2 == dy2 * dx1)
        {
            return 1;
        }

        // (p1, p4)와 (p2, p3)
        dx1 = p4[0] - p1[0];
        dy1 = p4[1] - p1[1];

        dx2 = p3[0] - p2[0];
        dy2 = p3[1] - p2[1];

        if (dy1 * dx2 == dy2 * dx1)
        {
            return 1;
        }

        return 0; // 평행한 직선이 없으면 0 반환
    }
}