using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers)
{
    int[] math1 = { 1, 2, 3, 4, 5};
    int math1Len = math1.Length;
    int[] math2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
    int math2Len = math2.Length;
    int[] math3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
    int math3Len = math3.Length;
    int[] mathAns = new int[3];
    for (int i = 0; i < answers.Length; i++)
    {
        if (answers[i] == math1[i % math1Len]) mathAns[0]++;
        if (answers[i] == math2[i % math2Len]) mathAns[1]++;
        if (answers[i] == math3[i % math3Len]) mathAns[2]++;
    }
    List<int> lstAnswer = new List<int>();
    if (mathAns[0] == mathAns.Max()) lstAnswer.Add(1);
    if (mathAns[1] == mathAns.Max()) lstAnswer.Add(2);
    if (mathAns[2] == mathAns.Max()) lstAnswer.Add(3);
    return lstAnswer.ToArray();
}
}