using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] arr = new int[n, n];
        int[] dx = { 0, 1, 0, -1 }; // 행 이동
        int[] dy = { 1, 0, -1, 0 }; // 열 이동
        int x = 0, y = 0, direction = 0;

        for (int num = 1; num <= n * n; num++)
        {
            arr[x, y] = num;
            int nx = x + dx[direction];
            int ny = y + dy[direction];

            if (nx < 0 || nx >= n || ny < 0 || ny >= n || arr[nx, ny] != 0)
            {
                direction = (direction + 1) % 4;
                nx = x + dx[direction];
                ny = y + dy[direction];
            }

            x = nx;
            y = ny;
        }

        return arr;
    }
}