public class Solution
{
    public string solution(string s)
    {
        char[] chars = s.ToCharArray();
        string answer = "";
        int num = s.Length / 2;
        answer = (s.Length % 2 != 0) ? chars[num].ToString() : chars[num - 1].ToString() + chars[num].ToString();
        return answer;
    }
}