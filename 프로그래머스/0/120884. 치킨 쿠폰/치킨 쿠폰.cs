using System;

public class Solution
{
    public int solution(int chicken)
    {
        int coupon = chicken;
        int serviceChicken = 0;

        while(coupon >= 10)
        {
            coupon -= 10;

            serviceChicken++;
            coupon++;
        }

        return serviceChicken;
    }
}