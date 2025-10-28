using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string letter)
    {
        Dictionary<string, char> morse = new Dictionary<string, char>()
        {
            {".-", 'a'},   {"-...", 'b'}, {"-.-.", 'c'}, {"-..", 'd'}, {".", 'e'},
            {"..-.", 'f'}, {"--.", 'g'},  {"....", 'h'}, {"..", 'i'},  {".---", 'j'},
            {"-.-", 'k'},  {".-..", 'l'}, {"--", 'm'},   {"-.", 'n'},  {"---", 'o'},
            {".--.", 'p'}, {"--.-", 'q'}, {".-.", 'r'},  {"...", 's'}, {"-", 't'},
            {"..-", 'u'},  {"...-", 'v'}, {".--", 'w'},  {"-..-", 'x'},{"-.--", 'y'},
            {"--..", 'z'}
        };

        string[] words = letter.Split(' ');
        string result = "";

        foreach (string code in words)
        {
            result += morse[code];
        }

        return result;
    }
}
