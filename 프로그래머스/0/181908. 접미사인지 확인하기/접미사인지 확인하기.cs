using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        if(my_string.Length < is_suffix.Length) return 0;
        if(my_string.IndexOf(is_suffix, my_string.Length - is_suffix.Length ) >= 0) return 1;
        return 0;
    }
}