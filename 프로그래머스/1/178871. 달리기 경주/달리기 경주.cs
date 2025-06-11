using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[] players, string[] callings)
{
    // 선수 이름 -> 현재 인덱스
    var playerIndex = new Dictionary<string, int>();
    // 인덱스 -> 선수 이름
    var indexPlayer = players.ToArray();

    for (int i = 0; i < players.Length; i++)
    {
        playerIndex[players[i]] = i;
    }

    foreach (string call in callings)
    {
        int idx = playerIndex[call];
        if (idx == 0) continue; // 이미 1등이면 스킵

        // 앞 선수와 스왑
        string frontPlayer = indexPlayer[idx - 1];

        // 인덱스 갱신
        playerIndex[call] = idx - 1;
        playerIndex[frontPlayer] = idx;

        // 배열에서 위치 교환
        indexPlayer[idx - 1] = call;
        indexPlayer[idx] = frontPlayer;
    }

    return indexPlayer;
}
}