public class Solution {
    public int[] solution(long n) {
        int cnt =0;
        long remain = n;
        while(remain!=0)
        {
            remain = remain / 10;
            cnt++;
        }
        int[] answer = new int[cnt];
        for (int i = 0; i < cnt; i++)
        {
            remain = n % 10;
            answer[i] = (int)remain;
            n = n / 10;
        }
        return answer;
    }
}