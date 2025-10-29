using System;

public class Solution {
   public int solution(int[] schedules, int[,] timelogs, int startday)
{
    int answer = 0;
    
    for (int i = 0; i < timelogs.GetLength(0); i++)
    {
        int cnt = 0;
        int afterday = startday;
        
        // 원본 배열을 수정하지 않도록 지역 변수 사용
        int adjustedSchedule = schedules[i];
        if ((adjustedSchedule + 10) % 100 >= 60)
            adjustedSchedule = adjustedSchedule + 50;
        else
            adjustedSchedule = adjustedSchedule + 10;
        
        for (int j = 0; j < timelogs.GetLength(1); j++)
        {
            // 주말 체크 수정 (토요일=6, 일요일=7)
            if (afterday == 6 || afterday == 7)
            {
                cnt++;
            }
            else if (timelogs[i, j] <= adjustedSchedule)
            {
                cnt++;
            }
            
            afterday++;
            if (afterday > 7)
                afterday = 1;
        }
        
        if (cnt == 7)  // timelogs.GetLength(1) 대신 7로 명시
            answer++;
    }
    return answer;
}
}