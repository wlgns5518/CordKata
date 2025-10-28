using System;
using System.Text;

public class Solution {
    public string solution(int age) {
        StringBuilder sb = new StringBuilder();
        
        while (age > 0)
        {
            // age의 마지막 자리 숫자 → 문자
            char c = (char)(age % 10 + 97);
            sb.Insert(0, c); // 맨 앞에 삽입
            age /= 10;
        }
        
        return sb.ToString();
    }
}
