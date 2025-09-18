using System;

public class Solution {
    public string[] solution(string[] str_list)
{
    int lIndex = Array.IndexOf(str_list, "l");
    int rIndex = Array.IndexOf(str_list, "r");

    // "l"과 "r"이 둘 다 없으면 빈 배열 반환
    if (lIndex == -1 && rIndex == -1)
        return Array.Empty<string>();

    string[] answer;

    if (rIndex == -1 || (lIndex != -1 && lIndex < rIndex))
    {
        // "l"이 먼저 나왔으면, 그 앞쪽 원소들 반환
        answer = new string[lIndex];
        for (int i = 0; i < lIndex; i++)
        {
            answer[i] = str_list[i];
        }
    }
    else
    {
        // "r"이 먼저 나왔으면, 그 뒤쪽 원소들 반환
        answer = new string[str_list.Length - (rIndex + 1)];
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = str_list[rIndex + 1 + i];
        }
    }

    return answer;
}
}