using System;

public class Solution {
     public string solution(string my_string, int m, int c)
 {
     int count = my_string.Length / m;
     string[] my_stringArray = new string[count];
     for (int i = 0; i < count; i++)
     {
         // 각 조각의 시작 인덱스는 i * m
         my_stringArray[i] = my_string.Substring(i * m, m);
     }

     var sb = new System.Text.StringBuilder();
     int index = c - 1; // c가 1-based라 가정하면 0-based로 변환
     if (index < 0) return "";

     for (int i = 0; i < count; i++)
     {
         // 안전하게 범위 검사 후 문자 추가
         if (index < my_stringArray[i].Length)
         {
             sb.Append(my_stringArray[i][index]);
         }
     }

     return sb.ToString();
 }
}