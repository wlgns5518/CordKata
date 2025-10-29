using System;

public class Solution
{
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
    {
        int videoLen = ToSeconds(video_len);
        int position = ToSeconds(pos);
        int opStart = ToSeconds(op_start);
        int opEnd = ToSeconds(op_end);

        foreach (string cmd in commands)
        {
            // 명령 수행 전 오프닝 체크
            if (position >= opStart && position <= opEnd)
                position = opEnd;

            if (cmd == "prev")
            {
                position = Math.Max(0, position - 10);
            }
            else if (cmd == "next")
            {
                position = Math.Min(videoLen, position + 10);
            }

            // 명령 수행 후 오프닝 체크
            if (position >= opStart && position <= opEnd)
                position = opEnd;
        }

        return ToTimeString(position);
    }

    private int ToSeconds(string time)
    {
        string[] parts = time.Split(':');
        int minutes = int.Parse(parts[0]);
        int seconds = int.Parse(parts[1]);
        return minutes * 60 + seconds;
    }

    private string ToTimeString(int totalSeconds)
    {
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;
        return $"{minutes:D2}:{seconds:D2}";
    }
}
