using System;
using System.Linq;

public class Solution {
     public string solution(string my_string)
 {
     string answer = string.Concat(my_string.Distinct());
     
     return answer;
 }
}