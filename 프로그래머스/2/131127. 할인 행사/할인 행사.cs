using System;
using System.Collections.Generic;

public class Solution {
     public int solution(string[] want, int[] number, string[] discount)
 {
     int answer = 0;
     int period = 10;

     // want 배열을 딕셔너리로 변환 (품목, 수량)
     var wantDict = new Dictionary<string, int>();
     for (int i = 0; i < want.Length; i++)
     {
         wantDict[want[i]] = number[i];
     }

     // 슬라이딩 윈도우로 10일씩 확인
     for (int i = 0; i <= discount.Length - period; i++)
     {
         var discountDict = new Dictionary<string, int>();
         // 현재 윈도우 내 할인 품목 카운트
         for (int j = i; j < i + period; j++)
         {
             if (discountDict.ContainsKey(discount[j]))
                 discountDict[discount[j]]++;
             else
                 discountDict[discount[j]] = 1;
         }

         // 원하는 품목과 수량이 모두 충족되는지 확인
         bool canRegister = true;
         foreach (var item in wantDict)
         {
             if (!discountDict.ContainsKey(item.Key) || discountDict[item.Key] < item.Value)
             {
                 canRegister = false;
                 break;
             }
         }
         if (canRegister)
             answer++;
     }

     return answer;
 }
}