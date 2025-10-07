using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> aList = arr.ToList();
        foreach(int i in delete_list) aList.Remove(i);
        return aList.ToArray();
    }
}