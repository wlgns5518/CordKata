public class Solution {
    public int solution(int n)
 {
     if (n == 0) return 0;
     if (n == 1 || n == 2) return 1;
     int answer = 0;
     int num1 = 1;
     int num2 = 1;
     int num3 = 0;

     for(int i=3;i<=n;i++)
     {
         num3 = (num1 + num2)% 1234567;
         num1 = num2;
         num2 = num3;
     }
     answer = num3;
     return answer;
 }
}