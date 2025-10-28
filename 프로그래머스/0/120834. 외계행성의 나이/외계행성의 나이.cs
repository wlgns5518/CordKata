using System;
using System.Text;

public class Solution {
    public string solution(int age) {
        StringBuilder sb = new StringBuilder();
        
        if (age == 0) return "a"; // age가 0일 경우 처리

        while (age > 0)
        {
            // 마지막 자리 숫자를 문자로 변환
            char c = (char)(age % 10 + 97);
            sb.Append(c); // 뒤에 붙임
            age /= 10;
        }
        
        // 뒤집어서 순서를 맞춤
        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
