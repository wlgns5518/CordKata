using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
       int card1Count = 0;
        int card2Count = 0;
        int goalCount = 0;
        while (goalCount != goal.Length)
        {
            if (cards1[card1Count] == goal[goalCount])
            {
                card1Count++;
                goalCount++;
                if (card1Count == cards1.Length)
                {
                    card1Count = cards1.Length-1;
                }
            }
            else if (cards2[card2Count] == goal[goalCount])
            {
                card2Count++;
                goalCount++;
                if(card2Count == cards2.Length)
                {
                    card2Count = cards2.Length-1;
                }
            }
            else
            {
                return "No";
            }
        }
        return "Yes";
    }
}