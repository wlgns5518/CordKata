using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    public int solution(int[] players, int m, int k)
    {
        int answer = 0;

        // window: (증설한 시각, 해당 시각에 증설한 서버 대수)
        var window = new Queue<(int hour, int count)>();
        int active = 0; // 현재 시간대에 운영 중인 증설 서버 수

        for (int i = 0; i < players.Length; i++)
        {
            // k시간 운영이 끝난 서버 제거 (i - k 이전/이하에 증설한 서버는 만료)
            while (window.Count > 0 && window.Peek().hour <= i - k)
            {
                active -= window.Dequeue().count;
            }

            // 필요한 증설 서버 수: floor(players[i] / m)
            int required = players[i] / m;

            if (required > active)
            {
                int add = required - active;
                answer += add;
                active += add;
                window.Enqueue((i, add)); // 이번 시간대에 증설
            }
        }

        return answer;
    }
}
