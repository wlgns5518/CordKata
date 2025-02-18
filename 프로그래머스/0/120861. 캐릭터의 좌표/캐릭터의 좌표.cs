using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board)
{
    int[] answer = new int[2];
    int xLimit = board[0] / 2;
    int yLimit = board[1] / 2;

    foreach (var key in keyinput)
    {
        switch (key)
        {
            case "up":
                if (answer[1] < yLimit) answer[1]++;
                break;
            case "down":
                if (answer[1] > -yLimit) answer[1]--;
                break;
            case "left":
                if (answer[0] > -xLimit) answer[0]--;
                break;
            case "right":
                if (answer[0] < xLimit) answer[0]++;
                break;
        }
    }
    return answer;
}
}