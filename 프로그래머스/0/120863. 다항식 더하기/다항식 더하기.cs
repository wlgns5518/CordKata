using System;

public class Solution
{
    public string solution(string polynomial)
    {
        string[] terms = polynomial.Split(" + "); // 항 분리
        int xSum = 0;
        int constSum = 0;

        foreach (string term in terms)
        {
            if (term.Contains("x"))
            {
                string coeff = term.Replace("x", "");
                xSum += string.IsNullOrEmpty(coeff) ? 1 : int.Parse(coeff);
            }
            else
            {
                constSum += int.Parse(term);
            }
        }

        string result = "";

        if (xSum > 0)
        {
            result += xSum == 1 ? "x" : xSum + "x";
        }

        if (constSum > 0)
        {
            if (xSum > 0) result += " + ";
            result += constSum;
        }

        return result;
    }
}
