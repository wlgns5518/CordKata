using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int n = Int32.Parse(s[0]);

        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            sb.Append('*');           // 한 줄에 별 추가
            Console.WriteLine(sb);    // 현재 상태 출력
        }
    }
}