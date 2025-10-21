using System;

public class Solution {
    public int solution(string my_string)
{
    int sum = 0;
    string num = ""; // 숫자 누적용

    foreach (char c in my_string)
    {
        if (char.IsDigit(c))
        {
            num += c; // 숫자이면 누적
        }
        else
        {
            if (num != "") // 숫자 스트링 끝나면 합산
            {
                sum += int.Parse(num);
                num = "";
            }
        }
    }

    // 마지막 숫자 처리
    if (num != "")
        sum += int.Parse(num);

    return sum;
}
}