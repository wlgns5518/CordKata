using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int row = arr.GetLength(0);
        int col = arr.GetLength(1);
        int n = Math.Max(row,col);
        //어차피 0으로 들어가있음
        int[,] answer = new int[n,n];
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                answer[i,j] = arr[i,j];
            }
        }
        return answer;
    }
}