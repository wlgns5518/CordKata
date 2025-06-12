public class Solution {
    public int solution(int[] arr)
{
    int answer = 0;
    int len = arr.Length;
    long maxValue = 1;
    int count = 0;
    for(int i=0;i<len;i++)
    {
        maxValue *= arr[i];
    }
    for(int i=1;i<=maxValue;i++)
    {
        for(int j=0;j<len;j++)
        {
            if (i % arr[j] == 0)
                count++;
        }
        if (count == len)
            return i;
        count = 0;
    }
    return answer;
}
}