public class Solution {
    public string solution(int a, int b) {
        int[] daysInMonth = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] daysOfWeek = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };

        int totalDays = b - 1;
        for (int i = 1; i < a; i++)
        {
            totalDays += daysInMonth[i];
        }
        int dayOfWeekIndex = (totalDays % 7 ) % 7;

        return daysOfWeek[dayOfWeekIndex];
    }
}