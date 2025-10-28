using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        while(hp >0)
        {
            Console.WriteLine(hp);
            if(hp/5 >0)
            {
                answer += hp/5;
                hp %= 5;
            }
                
            else if(hp/3 >0)
            {
                answer += hp/3;
                hp %=3;
            }
                
            else
            {
                answer += 1;
                hp--;
            }
                
        }
        return answer;
    }
}