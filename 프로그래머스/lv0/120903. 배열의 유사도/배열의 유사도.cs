using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        //s1원소와 s2원소가 겹치는게 있으면 그 숫자를 배열
        foreach (string element1 in s1){
            foreach (string element2 in s2){
                if(element1 == element2){
                    answer++;
                    break;
                }
            }
        }
        return answer;

    }
}