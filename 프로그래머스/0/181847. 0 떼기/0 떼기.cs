using System;

public class Solution {
    public string solution(string n_str) {
        int num = 0;
        int.TryParse(n_str,out num);
        return num.ToString();
    }
}