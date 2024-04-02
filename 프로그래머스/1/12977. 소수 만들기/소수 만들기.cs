class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int sumNum;
        bool isPrimeNum = false;
        for(int i=0;i<nums.Length; i++)
        {
            for(int j=i+1;j<nums.Length; j++)
            {
                for(int k=j+1;k<nums.Length;k++)
                {
                    sumNum = nums[i] + nums[j] + nums[k];
                    for(int o=2;o<sumNum;o++)
                    {
                        if (sumNum % o == 0)
                        {
                            isPrimeNum = false;
                            break;
                        }
                        else
                        {
                            isPrimeNum = true;
                        }
                    }
                    if(isPrimeNum == true)
                    {
                        answer++;
                    }
                }
            }
        }
        return answer;
    }
}