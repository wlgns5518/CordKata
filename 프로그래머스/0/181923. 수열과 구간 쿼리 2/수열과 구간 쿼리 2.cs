using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries)
{
    int[] answer = new int[queries.GetLength(0)];
    for (int i = 0; i < queries.GetLength(0); i++)
    {
        int minNum = 2000000;
        for (int j = queries[i, 0]; j <= queries[i, 1]; j++)
        {
            if (arr[j] > queries[i, 2])
            {
                if (minNum >= arr[j])
                    minNum = arr[j];
            }
        }
        if (minNum == 2000000)
            minNum = -1;
        answer[i] = minNum;
    }
    return answer;
}
}