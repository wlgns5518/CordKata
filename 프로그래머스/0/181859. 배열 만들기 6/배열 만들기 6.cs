using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        var answer = new Stack<int>();
        for(int i=0; i < arr.Length; i++)
        {
            if(answer.Count ==0)
                answer.Push(arr[i]);
            else if(answer.Peek() == arr[i])
                answer.Pop();
            else if(answer.Peek() != arr[i])
                answer.Push(arr[i]);
        }
        if(answer.Count == 0) answer.Push(-1);
        int[] answerArr = new int[answer.Count];
        for(int i = answer.Count-1; i>=0;i--)
        {
            answerArr[i] = answer.Pop();
        }
        return answerArr;
    }
}