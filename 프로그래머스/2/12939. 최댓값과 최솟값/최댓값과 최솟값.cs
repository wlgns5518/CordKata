using System;
using System.Linq;
public class Solution {
    public string solution(string s)
{
    string answer = "";
    var sSp = s.Split(' ');
    int n = sSp.Length;
    var sSpint = new int[n];
    for(int i=0;i< n; i++)
    {
        sSpint[i] = int.Parse(sSp[i]);
    }
    int minValue = sSpint.Min();
    int maxValue = sSpint.Max();
    answer = minValue.ToString() + " " + maxValue.ToString();
    return answer;
}
}