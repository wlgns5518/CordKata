using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        while(order >0)
        {
            int share = order%10;
            if(share ==3 || share ==6 || share == 9)
                answer++;
            order/=10;
        }
        return answer;
    }
}