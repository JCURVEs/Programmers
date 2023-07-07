using System;

public class Solution {
    public int solution(int a, int b, bool flag) {
        int answer = 0;
        int plus = a + b;
        if(flag == true)
        {
            return a+ b;
        }
        else
        {
            return a - b;
        }
        return answer;
    }
}