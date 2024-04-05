using System;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int[] answer = new int[2];
        int zeroCount = 0;
        int rightNum = 0;
        for(int i=0;i<lottos.Length;i++)
        {
            if (lottos[i] == 0)
                zeroCount++;
        }
        for(int i=0;i<lottos.Length;i++)
        {
            for(int j=0;j<win_nums.Length;j++)
            {
                if (lottos[i] == win_nums[j])
                    rightNum++;
            }
        }
        if(zeroCount !=0)
        {
            switch (rightNum)
            {
                case 0:
                case 1:
                    answer[0] = 6-zeroCount;
                    if (answer[0] == 0)
                        answer[0] = 1;
                    answer[1] = 6;
                    break;
                case 2:
                    answer[0] = 5 - zeroCount;
                    answer[1] = 5;
                    break;
                case 3:
                    answer[0] = 4 - zeroCount;
                    answer[1] = 4;
                    break;
                case 4:
                    answer[0] = 3 - zeroCount;
                    answer[1] = 3;
                    break;
                case 5:
                    answer[0] = 2 - zeroCount;
                    answer[1] = 2;
                    break;
                case 6:
                    answer[0] = 1;
                    answer[1] = 1;
                    break;

            }
        }
        else
        {
            switch(rightNum)
            {
                case 0:
                case 1:
                    answer[0] = 6;
                    answer[1] = 6;
                    break;
                case 2:
                    answer[0] = 5;
                    answer[1] = 5;
                    break;
                case 3:
                    answer[0] = 4;
                    answer[1] = 4;  
                    break;
                case 4:
                    answer[0] = 3;
                    answer[1] = 3;
                    break;
                case 5:
                    answer[0] = 2;
                    answer[1] = 2;
                    break;
                case 6:
                    answer[0] = 1;
                    answer[1] = 1;
                    break;

            }
        }
        return answer;
    }
}