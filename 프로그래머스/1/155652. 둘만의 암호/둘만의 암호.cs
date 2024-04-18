 using System;
    using System.Collections.Generic;

    public class Solution
    {
        public string solution(string s, string skip, int index)
        {
            string answer = "";
            List<int> list = new List<int>();
            
            // 아스키 코드 값 리스트
            foreach (char c in skip)
                list.Add(c);
            
            // 변환하는 문자열의 길이만큼 반복
            for (int i = 0; i < s.Length; i++)
            {
                int num = s[i];
                
                // 인덱스 값만큼 1씩 더해가면서 예외상황 체크
                for (int j = 0; j < index; j++)
                {
                    num++;
                    
                    // 범위 벗어남
                    if ('z' < num)
                        num = 'a';
                    
                    // skip list에 해당
                    if (list.Contains(num)) 
                        j--;
                }

                answer += (char)num;
            }
            
            return answer;
        }
    }