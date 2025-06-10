using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k)
{

    // 1. 중복 신고 제거
    var uniqueReports = new HashSet<string>(report);
    // 2. 신고당한 횟수 집계
    Dictionary<string, int> reportCounts = new Dictionary<string, int>();
    foreach (var id in id_list)
        reportCounts[id] = 0;

    // 3. 유저별 신고한 ID 목록 저장
    Dictionary<string, List<string>> userReports = new Dictionary<string, List<string>>();
    foreach (var id in id_list)
        userReports[id] = new List<string>();

    foreach (var rep in uniqueReports)
    {
        var parts = rep.Split(' ');
        string reporter = parts[0];
        string reported = parts[1];

        userReports[reporter].Add(reported);
        reportCounts[reported]++;
    }

    // 4. 정지된 유저 목록 추출
    var bannedUsers = reportCounts.Where(x => x.Value >= k).Select(x => x.Key).ToHashSet();

    // 5. 각 유저별로 처리 결과 메일 횟수 계산
    int[] answer = new int[id_list.Length];
    for (int i = 0; i < id_list.Length; i++)
    {
        string user = id_list[i];
        answer[i] = userReports[user].Count(reportedId => bannedUsers.Contains(reportedId));
    }

    return answer;
}
}