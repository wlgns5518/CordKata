public class Solution
{
    public string solution(string s, int n)
    {
        string answer = "";
        char[] chars = s.ToCharArray();
        int ASCII = 0;
        for(int i =0;i< chars.Length;i++)
        {
            ASCII = chars[i];
            if(ASCII >=65 && ASCII<=90)
            {
                ASCII += n;
                if(ASCII >90)
                    ASCII -= 26;
            }
            if (ASCII >= 97 && ASCII <= 122)
            {
                ASCII += n;
                if(ASCII > 122)
                    ASCII -= 26;
            }
            chars[i] = (char)ASCII;
            answer += chars[i];
        }
        return answer;
    }
}