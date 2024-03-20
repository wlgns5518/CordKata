public class Solution
    {
        public int[] solution(string s)
        {
            int[] answer = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j >=0; j--)
                {
                    if ((s[i] == s[j]&& i-j>0))
                    {
                        answer[i] = i-j;
                        break;
                    }
                    else
                    {
                        answer[i] = -1;
                    }
                }
            }
            return answer;
        }
    }