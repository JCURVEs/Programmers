using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        int answer = 0;
        
        string plus = ineq + eq;
        if(plus == "<=")
        {
            if(n <= m)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        if(plus == ">=")
        {
            if(n >= m)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        if(plus ==">!")
        {
            if(n > m)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        if(plus =="<!")
        {
            if(n<m)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        return answer;
    }
}