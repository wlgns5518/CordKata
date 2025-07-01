using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location)
{
    Queue<(int priority, int index)> queue = new Queue<(int, int)>();
    for (int i = 0; i < priorities.Length; i++)
    {
        queue.Enqueue((priorities[i], i));
    }

    int order = 0;
    while (queue.Count > 0)
    {
        var current = queue.Dequeue();
        // 큐에 현재보다 우선순위가 높은 프로세스가 있는지 확인
        if (queue.Any(x => x.priority > current.priority))
        {
            queue.Enqueue(current);
        }
        else
        {
            order++;
            if (current.index == location)
                return order;
        }
    }
    return -1; // 이론상 도달하지 않음
}
}