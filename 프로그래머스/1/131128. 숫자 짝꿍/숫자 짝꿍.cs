using System;

public class Solution {
    public string solution(string X, string Y)
{
    int[] countX = new int[10];
    int[] countY = new int[10];

    foreach (char ch in X)
        countX[ch - '0']++;

    foreach (char ch in Y)
        countY[ch - '0']++;

    var sb = new System.Text.StringBuilder();

    for (int d = 9; d >= 0; d--)
    {
        int c = Math.Min(countX[d], countY[d]);
        if (c > 0)
            sb.Append(new string((char)('0' + d), c));
    }

    if (sb.Length == 0)
        return "-1";

    if (sb[0] == '0') // 모두 0인 경우
        return "0";

    return sb.ToString();
}
}