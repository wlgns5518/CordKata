using System;
    using System.Collections.Generic;

    public class Solution
    {
        public int solution(int[] ingredient)
        {
            int answer = 0;
            var list = new List<int>();

            foreach (int num in ingredient)
            {
                // 리스트에 하나씩 추가해나감
                list.Add(num);

                // list의 크기가 4이상이면 체크 시작
                if (list.Count >= 4)
                {
                    // 햄버거를 만들 수 있다면 무조건 마지막 인덱스를 기준으로 이루어짐
                    if (list[list.Count - 4] == 1 && list[list.Count - 3] == 2 &&
                       list[list.Count - 2] == 3 && list[list.Count - 1] == 1)
                    {
                        // 햄버거를 만듬
                        answer++;
                        list.RemoveRange(list.Count - 4, 4);
                    }
                }
            }
            return answer;
        }
    }