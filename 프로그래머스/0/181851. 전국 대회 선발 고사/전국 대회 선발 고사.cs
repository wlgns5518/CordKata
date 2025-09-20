using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] rank, bool[] attendance)
{
    int n = rank.Length;
    
    // 출석한 학생들의 (등수, 번호) 저장
    List<(int rank, int index)> attendedStudents = new List<(int, int)>();
    
    for (int i = 0; i < n; i++)
    {
        if (attendance[i])
        {
            attendedStudents.Add((rank[i], i));
        }
    }
    
    // 등수를 기준으로 정렬 (오름차순)
    attendedStudents.Sort((x, y) => x.rank.CompareTo(y.rank));
    
    // 상위 3명이 있는지 확인
    if (attendedStudents.Count < 3)
    {
        throw new InvalidOperationException("출석한 학생이 3명 미만입니다.");
    }
    
    // 상위 3명 학생 번호 추출
    int a = attendedStudents[0].index;  // 1등
    int b = attendedStudents[1].index;  // 2등
    int c = attendedStudents[2].index;  // 3등
    
    return 10000 * a + 100 * b + c;
}
}