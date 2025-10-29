using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] friends, string[] gifts)
{
    int answer = 0;
    var friendsDicGive = new Dictionary<string, int>();
    var friendsDicTake = new Dictionary<string, int>();
    
    for (int i = 0; i < friends.Length; i++)
    {
        friendsDicGive.Add(friends[i], 0);
        friendsDicTake.Add(friends[i], 0);
    }
    
    // 선물 주고받은 기록 저장
    var giftRecord = new Dictionary<string, int>();
    
    for (int i = 0; i < gifts.Length; i++)
    {
        var parts = gifts[i].Split();
        friendsDicGive[parts[0]]++;
        friendsDicTake[parts[1]]++;
        
        // "A B" 형태로 저장
        string key = gifts[i];
        if (!giftRecord.ContainsKey(key))
            giftRecord[key] = 0;
        giftRecord[key]++;
    }
    
    // 선물 지수 계산
    var giftIndex = new Dictionary<string, int>();
    for (int i = 0; i < friends.Length; i++)
    {
        giftIndex[friends[i]] = friendsDicGive[friends[i]] - friendsDicTake[friends[i]];
    }
    
    // 다음 달에 받을 선물 개수 계산
    var nextMonthGifts = new Dictionary<string, int>();
    for (int i = 0; i < friends.Length; i++)
    {
        nextMonthGifts[friends[i]] = 0;
    }
    
    // 모든 친구 쌍 비교
    for (int i = 0; i < friends.Length; i++)
    {
        for (int j = i + 1; j < friends.Length; j++)
        {
            string personA = friends[i];
            string personB = friends[j];
            
            // A가 B에게 준 횟수
            string keyAtoB = personA + " " + personB;
            int aToB = giftRecord.ContainsKey(keyAtoB) ? giftRecord[keyAtoB] : 0;
            
            // B가 A에게 준 횟수
            string keyBtoA = personB + " " + personA;
            int bToA = giftRecord.ContainsKey(keyBtoA) ? giftRecord[keyBtoA] : 0;
            
            if (aToB > bToA)
            {
                // A가 더 많이 줬으면 A가 받음
                nextMonthGifts[personA]++;
            }
            else if (bToA > aToB)
            {
                // B가 더 많이 줬으면 B가 받음
                nextMonthGifts[personB]++;
            }
            else
            {
                // 같거나 없으면 선물 지수 비교
                if (giftIndex[personA] > giftIndex[personB])
                {
                    nextMonthGifts[personA]++;
                }
                else if (giftIndex[personB] > giftIndex[personA])
                {
                    nextMonthGifts[personB]++;
                }
            }
        }
    }
    
    // 가장 많이 받을 선물 개수
    foreach (var count in nextMonthGifts.Values)
    {
        if (count > answer)
            answer = count;
    }
    
    return answer;
}
}
