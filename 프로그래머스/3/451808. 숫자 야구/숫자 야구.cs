using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, Func<int, string> submit) {
        // 1~9 사이의 서로 다른 숫자 4개로 이루어진 모든 조합 생성
        List<int[]> candidates = GenerateAllCandidates();
        
        int attempts = 0;
        
        while (attempts < n) {
            // 후보가 1개만 남으면 정답
            if (candidates.Count == 1) {
                return ArrayToNumber(candidates[0]);
            }
            
            // 최적의 질의 선택
            int[] query = FindBestQuery(candidates);
            int queryNum = ArrayToNumber(query);
            
            // 제출 및 결과 받기
            string result = submit(queryNum);
            attempts++;
            
            // 정답을 찾았으면 반환
            if (result == "4S 0B") {
                return queryNum;
            }
            
            // 결과에 맞지 않는 후보들 제거
            candidates = FilterCandidates(candidates, query, result);
            
            if (candidates.Count == 0) {
                break;
            }
        }
        
        // 최종 후보 반환
        if (candidates.Count > 0) {
            return ArrayToNumber(candidates[0]);
        }
        
        return -1;
    }
    
    // 1~9 사이의 서로 다른 숫자 4개로 이루어진 모든 순열 생성
    private List<int[]> GenerateAllCandidates() {
        List<int[]> result = new List<int[]>();
        int[] digits = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        // 4개를 선택하는 순열 생성
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (j == i) continue;
                for (int k = 0; k < 9; k++) {
                    if (k == i || k == j) continue;
                    for (int l = 0; l < 9; l++) {
                        if (l == i || l == j || l == k) continue;
                        result.Add(new int[] { digits[i], digits[j], digits[k], digits[l] });
                    }
                }
            }
        }
        
        return result;
    }
    
    // guess와 target을 비교하여 결과 계산
    private string CalculateResult(int[] guess, int[] target) {
        int strike = 0;
        int ball = 0;
        
        for (int i = 0; i < 4; i++) {
            if (guess[i] == target[i]) {
                strike++;
            } else if (target.Contains(guess[i])) {
                ball++;
            }
        }
        
        return $"{strike}S {ball}B";
    }
    
    // 최적의 질의 찾기
    private int[] FindBestQuery(List<int[]> candidates) {
        if (candidates.Count <= 2) {
            return candidates[0];
        }
        
        // 샘플링으로 성능 최적화
        int sampleSize = Math.Min(candidates.Count, 50);
        List<int[]> sample = candidates.Count > sampleSize 
            ? candidates.OrderBy(x => Guid.NewGuid()).Take(sampleSize).ToList()
            : candidates;
        
        int[] bestQuery = null;
        int minWorstCase = int.MaxValue;
        
        foreach (var query in sample) {
            // 이 쿼리로 얻을 수 있는 결과들의 분포 계산
            Dictionary<string, int> resultCounts = new Dictionary<string, int>();
            
            foreach (var candidate in candidates) {
                string result = CalculateResult(query, candidate);
                if (!resultCounts.ContainsKey(result)) {
                    resultCounts[result] = 0;
                }
                resultCounts[result]++;
            }
            
            // 최악의 경우 (가장 많이 남는 그룹의 크기)
            int worstCase = resultCounts.Values.Max();
            
            if (worstCase < minWorstCase) {
                minWorstCase = worstCase;
                bestQuery = query;
            }
        }
        
        return bestQuery;
    }
    
    // 결과에 맞는 후보들만 필터링
    private List<int[]> FilterCandidates(List<int[]> candidates, int[] query, string expectedResult) {
        List<int[]> filtered = new List<int[]>();
        
        foreach (var candidate in candidates) {
            if (CalculateResult(query, candidate) == expectedResult) {
                filtered.Add(candidate);
            }
        }
        
        return filtered;
    }
    
    // 배열을 숫자로 변환
    private int ArrayToNumber(int[] arr) {
        return arr[0] * 1000 + arr[1] * 100 + arr[2] * 10 + arr[3];
    }
}