using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] friends, string[] gifts)
{
    int answer = 0;
    int n = friends.Length;
    
    // 친구 이름 -> 인덱스 매핑
    var nameToIndex = new Dictionary<string, int>();
    for (int i = 0; i < n; i++)
    {
        nameToIndex[friends[i]] = i;
    }
    
    // 선물 주고받은 기록 (i->j: i가 j에게 준 횟수)
    int[,] giftTable = new int[n, n];
    
    // 선물 지수 계산용
    var friendsDicGive = new Dictionary<string, int>();
    var friendsDicTake = new Dictionary<string, int>();
    
    for (int i = 0; i < n; i++)
    {
        friendsDicGive.Add(friends[i], 0);
        friendsDicTake.Add(friends[i], 0);
    }
    
    // 선물 기록 처리
    for (int i = 0; i < gifts.Length; i++)
    {
        var parts = gifts[i].Split();
        string giver = parts[0];
        string receiver = parts[1];
        
        friendsDicGive[giver]++;
        friendsDicTake[receiver]++;
        
        int giverIdx = nameToIndex[giver];
        int receiverIdx = nameToIndex[receiver];
        giftTable[giverIdx, receiverIdx]++;
    }
    
    // 선물 지수 계산
    var giftIndex = new Dictionary<string, int>();
    for (int i = 0; i < n; i++)
    {
        giftIndex[friends[i]] = friendsDicGive[friends[i]] - friendsDicTake[friends[i]];
    }
    
    // 다음 달에 받을 선물 개수 계산
    int[] nextMonthGifts = new int[n];
    
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            string personA = friends[i];
            string personB = friends[j];
            
            int aToB = giftTable[i, j];
            int bToA = giftTable[j, i];
            
            if (aToB > bToA)
            {
                // A가 B보다 더 많이 줬으면 A가 받음
                nextMonthGifts[i]++;
            }
            else if (bToA > aToB)
            {
                // B가 A보다 더 많이 줬으면 B가 받음
                nextMonthGifts[j]++;
            }
            else
            {
                // 같거나 기록이 없으면 선물 지수 비교
                int indexA = giftIndex[personA];
                int indexB = giftIndex[personB];
                
                if (indexA > indexB)
                {
                    nextMonthGifts[i]++;
                }
                else if (indexB > indexA)
                {
                    nextMonthGifts[j]++;
                }
                // 선물 지수도 같으면 아무것도 안 함
            }
        }
    }
    
    // 가장 많이 받을 선물 개수 찾기
    answer = nextMonthGifts.Max();
    
    return answer;
}
}
