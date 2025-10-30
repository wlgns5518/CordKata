using System;

public class Solution {
    int items;
    int[,] info;
    int n, m;
    int minA;
    bool[,,] visited; // 메모이제이션

    public int solution(int[,] info, int n, int m) {
        this.items = info.GetLength(0);
        this.info = info;
        this.n = n;
        this.m = m;
        minA = int.MaxValue;

        visited = new bool[items + 1, n, m]; // idx, aSum, bSum

        DFS(0, 0, 0);

        return minA == int.MaxValue ? -1 : minA;
    }

    void DFS(int idx, int aSum, int bSum) {
        // 경찰 잡힘
        if (aSum >= n || bSum >= m) return;

        // 이미 방문한 상태면 탐색 X
        if (visited[idx, aSum, bSum]) return;
        visited[idx, aSum, bSum] = true;

        // 모든 물건 훔침
        if (idx == items) {
            minA = Math.Min(minA, aSum);
            return;
        }

        // A가 훔치기
        DFS(idx + 1, aSum + info[idx,0], bSum);

        // B가 훔치기
        DFS(idx + 1, aSum, bSum + info[idx,1]);
    }
}
