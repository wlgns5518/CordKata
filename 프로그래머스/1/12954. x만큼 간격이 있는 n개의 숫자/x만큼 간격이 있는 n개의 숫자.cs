public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
        int i = 0;
        if (x > 0)
        {
            for (long j = x; j <= (long)x * n; j += x)
            {
                answer[i] = j;
                i++;
            }
        }
        else if(x< 0)
        {
            for (long j = x; j >= (long)x * n; j += x)
            {
                answer[i] = j;
                i++;
            }
        }
        else
        {
            for (long j = 0; j < n; j ++)
            {
                answer[i] = 0;
                i++;
            }
        }
        return answer;
    }
}