using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;

        int ant_5 = hp / 5;
        int ant_3 = (hp % 5) / 3  ;
        int ant_1 = (hp % 5) % 3 / 1 ;

        return ant_5 + ant_3 + ant_1;
    }
}