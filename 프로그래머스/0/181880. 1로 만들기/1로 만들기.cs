using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0; 
        bool isAllOne = true;
        while(isAllOne)
        {
            int count = 0;
            for(int i=0;i<num_list.Length;i++)
            {
                if(num_list[i]==1)
                    count++;
                else
                {
                    answer++;
                    if(num_list[i] %2 == 0)
                        num_list[i]/=2;
                    else
                        num_list[i] = (num_list[i]-1)/2;
                }
            }
            if(count == num_list.Length)
                isAllOne = false;
        }
        return answer;
    }
}