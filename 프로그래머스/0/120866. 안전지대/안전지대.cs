using System;

public class Solution {
    public int solution(int[,] board)
{
    int answer = 0;
    int rows = board.GetLength(0);
    int cols = board.GetLength(1);

    // 8방향 델타 배열 (상, 하, 좌, 우, 대각선 4개)
    int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
    int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (board[i, j] != 1)
            {
                bool hasOneAround = false;

                for (int d = 0; d < 8; d++)
                {
                    int ni = i + dx[d];
                    int nj = j + dy[d];

                    // 배열 범위 체크
                    if (ni >= 0 && ni < rows && nj >= 0 && nj < cols)
                    {
                        if (board[ni, nj] == 1)
                        {
                            hasOneAround = true;
                            break;
                        }
                    }
                }

                if (!hasOneAround)
                {
                    // 주변 8칸에 1이 없고, 자신도 1이 아님
                    answer++;
                }
            }
        }
    }

    return answer;
}
}