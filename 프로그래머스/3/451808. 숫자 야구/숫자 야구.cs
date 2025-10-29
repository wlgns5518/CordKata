using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int n, Func<int, string> submit) 
    {
        HashSet<int> hold = new HashSet<int>();
        
        // 4자리 숫자 생성 (각 자리 숫자가 서로 다름)
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                if (i != j)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        if (k != i && k != j)
                        {
                            for (int w = 1; w <= 9; w++)
                            {
                                if (w != i && w != j && w != k)
                                {
                                    int num = i * 1000 + j * 100 + k * 10 + w;
                                    hold.Add(num);
                                }
                            }
                        }
                    }
                }
            }
        }

        // 체크 함수
        Func<int, int, string, bool> check = (a, b, res) =>
        {
            int x = res[0] - '0';
            int y = res[3] - '0';

            int[] A = new int[4] 
            { 
                a % 10, 
                a / 10 % 10, 
                a / 100 % 10, 
                a / 1000 
            };
            
            int[] B = new int[4] 
            { 
                b % 10, 
                b / 10 % 10, 
                b / 100 % 10, 
                b / 1000 
            };

            // 같은 위치에 같은 숫자 개수 (Strike)
            int cnt = 0;
            for (int i = 0; i < 4; i++)
            {
                if (A[i] == B[i]) cnt++;
            }

            if (x != cnt) return false;

            // 다른 위치에 같은 숫자 개수 (Ball)
            cnt = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i != j && A[i] == B[j])
                    {
                        cnt++;
                    }
                }
            }

            return y == cnt;
        };

        // 메인 로직
        for (int i = 0; i < n; i++)
        {
            int now = hold.Min();
            string res = submit(now);

            // 조건에 맞지 않는 숫자 제거
            hold.RemoveWhere(val => !check(now, val, res));

            if (hold.Count == 1)
            {
                return hold.First();
            }
        }

        return hold.Min();
    }
}