using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[,] score)
    {
        List<int> scoreList = new List<int>();
        List<int> rankList = new List<int>();

        for(int i=0; i<score.GetLength(0); i++)
        {
            scoreList.Add(score[i, 0] + score[i, 1]);
        }

        List<int> sortScore = scoreList.OrderByDescending(x => x).ToList();

        for(int i=0; i<sortScore.Count; i++)
        {
            rankList.Add(sortScore.FindIndex(x => x == scoreList[i]) + 1);
        }

        return rankList.ToArray();
    }
}