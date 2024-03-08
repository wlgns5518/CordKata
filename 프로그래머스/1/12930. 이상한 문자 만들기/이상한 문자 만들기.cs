public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        string[] sArray = s.Split(' ');
        for(int i=0; i<sArray.Length;i++)
        {
            for (int j = 0; j < sArray[i].Length; j++)
            {
                if(j%2 == 0)
                {
                    answer += char.ToUpper(sArray[i][j]);
                }
                else
                {
                    answer += char.ToLower(sArray[i][j]);
                }
            }
            if(i != sArray.Length-1)
                answer += ' ';
        }
        
        return answer;
    }
}