using System;
using System.Linq;

public class Solution {
    public int solution(string myString, string pat) {

        return myString.ToUpper().IndexOf(pat.ToUpper()) == -1 ? 0 : 1;
    }
}