using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] park, string[] routes)
{
    int h = park.Length;
    int w = park[0].Length;
    int x = 0, y = 0;

    // 시작 위치 찾기
    for (int i = 0; i < h; i++)
    {
        int idx = park[i].IndexOf('S');
        if (idx != -1)
        {
            x = i;
            y = idx;
            break;
        }
    }

    // 방향 벡터
    var dir = new Dictionary<string, (int dx, int dy)>
    {
        { "N", (-1, 0) },
        { "S", (1, 0) },
        { "W", (0, -1) },
        { "E", (0, 1) }
    };

    foreach (var route in routes)
    {
        var parts = route.Split(' ');
        string d = parts[0];
        int dist = int.Parse(parts[1]);

        int nx = x, ny = y;
        bool canMove = true;

        for (int step = 1; step <= dist; step++)
        {
            int tx = x + dir[d].dx * step;
            int ty = y + dir[d].dy * step;

            // 공원 밖 or 장애물
            if (tx < 0 || tx >= h || ty < 0 || ty >= w || park[tx][ty] == 'X')
            {
                canMove = false;
                break;
            }
        }

        if (canMove)
        {
            x += dir[d].dx * dist;
            y += dir[d].dy * dist;
        }
    }

    return new int[] { x, y };
}
}