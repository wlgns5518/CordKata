using System;

public class Solution {
    public string solution(string my_string, int[,] queries)
{
    if (my_string == null) return null;
    char[] chars = my_string.ToCharArray();
    int rows = queries.GetLength(0);
    for (int i = 0; i < rows; i++)
    {
        int s = queries[i, 0];
        int e = queries[i, 1];
        // 인덱스 s..e 구간을 in-place로 뒤집기
        while (s < e)
        {
            char tmp = chars[s];
            chars[s] = chars[e];
            chars[e] = tmp;
            s++; e--;
        }
    }
    return new string(chars);
}
}