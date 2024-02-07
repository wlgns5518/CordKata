public class Solution
{
    public bool solution(int x)
    {
        int remain=x;
        int sum = 0;

        for(int i = 0; i < x.ToString().Length;i++) 
        {
            sum += remain % 10;
            remain /= 10;
        }
        if (x % sum == 0)
            return true;
        else
            return false;
       
    }
}