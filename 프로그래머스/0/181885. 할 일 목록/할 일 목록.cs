using System;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        // false인 항목 개수 세기
        int count = 0;
        for (int i = 0; i < finished.Length; i++) {
            if (!finished[i]) count++;
        }

        // false인 항목을 담을 배열 생성
        string[] answer = new string[count];
        int idx = 0;
        for (int i = 0; i < finished.Length; i++) {
            if (!finished[i]) {
                answer[idx] = todo_list[i];
                idx++;
            }
        }

        return answer;
    }
}
