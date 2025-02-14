using System;
using System.Linq;

public class Solution {
     public int[] solution(string my_string)
{
    // 숫자만 추출
    string numstr = string.Concat(my_string.Where(char.IsDigit));

    // 숫자를 int 배열로 변환
    int[] answer = numstr.Select(c => c - '0').ToArray();

    // 배열 정렬
    Array.Sort(answer);

    return answer;
}
}