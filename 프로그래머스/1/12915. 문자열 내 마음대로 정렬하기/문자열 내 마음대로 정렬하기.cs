using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        Array.Sort(strings, (x, y) =>
            {
                if (x[n] == y[n])
                {
                    return string.Compare(x, y); 
                }
                else
                {
                    return x[n].CompareTo(y[n]); 
                }
            });

            return strings;
    }
}