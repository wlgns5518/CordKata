public class Solution
{
    public int solution(string t, string p)
    {
        int answer = 0;
        string sumt = "";
        for(int i=0;i<=t.Length-p.Length;i++)
        {
            sumt = "";
            for (int j =0;j<p.Length;j++)
            {
                    sumt += t[i+j];
            }
            if (long.Parse(sumt) <= long.Parse(p))
                answer++;
        }
        return answer;
    }
}