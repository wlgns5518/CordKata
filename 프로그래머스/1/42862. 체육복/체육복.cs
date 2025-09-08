using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {

            int[] Person = new int[n];
            for(int i = 0; i < n; i++)
            {
                Person[i] = 1;
            }


            for(int i = 0; i < lost.Length; i++)
            {
                Person[lost[i] - 1]--;
            }


            for(int i = 0; i < reserve.Length; i++)
            {
                Person[reserve[i] - 1]++;
            }


            for(int i = 0; i < Person.Length - 1; i++)
            {
                if(Math.Abs(Person[i] - Person[i+1]) == 2)
                {
                    Person[i] = 1;
                    Person[i + 1] = 1;
                }
            }


            int count = 0;
            for(int i = 0; i < Person.Length; i++)
            {
                if(Person[i] == 0)
                {
                    count++;
                }
            }

            return Person.Length - count;
    }
}