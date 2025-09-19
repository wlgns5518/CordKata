using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        if(arr1.Length == arr2.Length)
        {
            int arr1Sum = arr1.Sum();
            int arr2Sum = arr2.Sum();
            if(arr1Sum>arr2Sum)
                return 1;
            else if(arr1Sum == arr2Sum)
                return 0;
            else
                return -1;
        }
        else
        {
            if(arr1.Length>arr2.Length)
                return 1;
            else
                return -1;
        }
    }
}