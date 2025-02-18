using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db)
{
    string answer = "fail";
    string id = id_pw[0];
    string pw = id_pw[1];
    for(int i=0;i<db.GetLength(0);i++)
    {
        if (db[i, 0] == id)
        {
            if (db[i, 1] == pw)
                return "login";
            else
                return "wrong pw";
        }
    }
    return answer;
}
}