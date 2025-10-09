using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        int num = 0;
        for(int i=0;i<babbling.Length;i++)
        {
            babbling[i] = babbling[i].Replace("aya","1");
            babbling[i] = babbling[i].Replace("ye","1");
            babbling[i] = babbling[i].Replace("woo","1");
            babbling[i] = babbling[i].Replace("ma","1");
            if(int.TryParse(babbling[i], out num))
                answer++;
        }
        return answer;
    }
}