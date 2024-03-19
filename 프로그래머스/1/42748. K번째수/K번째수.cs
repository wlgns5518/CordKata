using System.Collections.Generic;

public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            for(int i=0;i<commands.GetLength(0);i++)
            {
                List<int> sortArray = new List<int>();
                for (int k = commands[i, 0]-1; k <= commands[i,1]-1;k++)
                {
                    sortArray.Add(array[k]);
                }
                sortArray.Sort();
                answer[i] += sortArray[commands[i, 2]-1];
            }
            return answer;
        }
    }