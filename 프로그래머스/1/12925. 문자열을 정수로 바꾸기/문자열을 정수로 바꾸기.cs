public class Solution
{
    public int solution(string s)
    {
        if (s.Length>=1 && s.Length <= 5)
        {
            int answer = int.Parse(s);
            return answer;
        }
        return 0;
    }
}