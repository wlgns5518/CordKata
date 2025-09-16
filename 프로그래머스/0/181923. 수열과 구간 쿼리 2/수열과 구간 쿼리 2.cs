using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[,] queries)
{
    int[] answer = new int[queries.GetLength(0)];
    for (int i = 0; i < queries.GetLength(0); i++)
    {
        int minNum = int.MaxValue;
        for (int j = queries[i, 0]; j <= queries[i, 1]; j++)
        {
            if (arr[j] > queries[i, 2])
            {
                if (minNum >= arr[j])
                    minNum = arr[j];
            }
        }
        if (minNum == int.MaxValue)
            minNum = -1;
        answer[i] = minNum;
    }
    return answer;
}
}