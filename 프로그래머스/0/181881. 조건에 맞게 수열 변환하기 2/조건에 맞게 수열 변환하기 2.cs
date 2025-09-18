using System;

public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        bool changed = true;

        while(changed) {
            changed = false; // 이번 반복에서 변화가 있었는지 체크
            for(int i = 0; i < arr.Length; i++) {
                if(arr[i] >= 50 && arr[i] % 2 == 0) {
                    arr[i] /= 2;
                    changed = true;
                } else if(arr[i] < 50 && arr[i] % 2 != 0) {
                    arr[i] = arr[i]*2+1;
                    changed = true;
                }
            }
            if(changed) answer++; // 변화가 있을 때만 반복 횟수 증가
        }

        return answer;
    }
}
