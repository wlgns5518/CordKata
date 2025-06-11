using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] fees, string[] records)
{
    var inTime = new Dictionary<string, int>();
    var totalTime = new Dictionary<string, int>();

    foreach (var record in records)
    {
        var parts = record.Split(' ');
        var time = parts[0];
        var car = parts[1];
        var type = parts[2];

        int minutes = int.Parse(time.Substring(0, 2)) * 60 + int.Parse(time.Substring(3, 2));

        if (type == "IN")
        {
            inTime[car] = minutes;
        }
        else // 출차
        {
            if (inTime.ContainsKey(car))
            {
                int parked = minutes - inTime[car];
                if (!totalTime.ContainsKey(car)) totalTime[car] = 0;
                totalTime[car] += parked;
                inTime.Remove(car);
            }
            // else: 입차 기록이 없는 출차는 무시 (데이터 오류 방지)
        }
    }

    // 출차 기록이 없는 차량은 23:59에 출차 처리
    foreach (var car in inTime.Keys)
    {
        int parked = (23 * 60 + 59) - inTime[car];
        if (!totalTime.ContainsKey(car)) totalTime[car] = 0;
        totalTime[car] += parked;
    }

    // 차량 번호 오름차순 정렬 후 요금 계산
    var answer = new List<int>();
    foreach (var car in totalTime.Keys.OrderBy(x => x))
    {
        int time = totalTime[car];
        int fee = fees[1];
        if (time > fees[0])
        {
            fee += (int)Math.Ceiling((time - fees[0]) / (double)fees[2]) * fees[3];
        }
        answer.Add(fee);
    }
    return answer.ToArray();
}
}