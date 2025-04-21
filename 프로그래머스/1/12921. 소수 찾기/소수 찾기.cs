public class Solution {
    public int solution(int n) {
        if (n <= 1) return 0;
        if (n == 2) return 1;
        
        // 2는 유일한 짝수 소수이므로 미리 카운트하고 시작
        int answer = 1;
        
        // 에라토스테네스의 체 구현
        bool[] isComposite = new bool[n + 1];
        
        // 짝수는 모두 합성수로 표시 (2 제외)
        for (int i = 4; i <= n; i += 2) {
            isComposite[i] = true;
        }
        
        // 홀수만 검사
        for (int i = 3; i * i <= n; i += 2) {
            if (!isComposite[i]) {
                // i의 배수를 모두 합성수로 표시
                for (int j = i * i; j <= n; j += 2 * i) {
                    isComposite[j] = true;
                }
            }
        }
        
        // 홀수 중 소수 카운트
        for (int i = 3; i <= n; i += 2) {
            if (!isComposite[i]) {
                answer++;
            }
        }
        
        return answer;
    }
}