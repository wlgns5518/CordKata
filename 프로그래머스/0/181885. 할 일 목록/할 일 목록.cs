using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        var answer = new List<String>();
        for(int i=0;i<finished.Length;i++)
        {
            if(finished[i] == false)
                answer.Add(todo_list[i]);
        }
        return answer.ToArray();
    }
}