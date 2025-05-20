public class Solution
{
    public string solution(string s)
    {
        string[] sArray = s.Split(' ');
        string[] UpperArray = new string[sArray.Length];
        for (int i = 0; i < sArray.Length; i++)
        {
            if (!string.IsNullOrEmpty(sArray[i]))
            {
                UpperArray[i] = char.ToUpper(sArray[i][0]) + sArray[i].Substring(1).ToLower();
            }
            else
            {
                UpperArray[i] = sArray[i]; // 빈 문자열 처리
            }
        }
        string answer = "";
        for(int i=0;i<UpperArray.Length;i++)
        {
            if (i == UpperArray.Length - 1)
            {
                answer += UpperArray[i];
            }
            else
            {
                answer += UpperArray[i] + " ";
            }
        }
        return answer;
    }
}