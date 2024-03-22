using System;
using System.Linq;
public class Solution
{
    public string solution(int[] food)
    {
        string answer = "";
        string player1 = "";
        string player2 = "";
        for(int i =1;i<food.Length;i++)
        {
            if (food[i]/2 >= 1)
            {
                int foodCount = food[i]/2;
                for(int j =0;j<foodCount;j++)
                {
                    player1 += i.ToString();
                    player2 += i.ToString();
                }
            }
        }
        string reverse = new string(player2.Reverse().ToArray());
        answer = player1 + "0" + reverse;
        return answer;
    }
}