using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] talk = new string[] { "aya", "ye", "woo", "ma" };

            for (int i = 0; i < babbling.Length; i++)
            {
                for (int j = 0; j < talk.Length; j++)
                {
                    string str = talk[j] + talk[j];
                    babbling[i] = babbling[i].Replace(str, "@").Replace(talk[j], " ");
                }
                if (babbling[i].Trim().Length < 1) { answer++; }
            }
            return answer;
    }
}