using System;

public class Solution {
    public int[] solution(int n) {
        int sqrt = (int)Math.Sqrt(n);
        int[] divisors = new int[sqrt * 2];
        int count = 0;
        
        for (int i = 1; i <= sqrt; i++) {
            if (n % i == 0) {
                divisors[count++] = i;
                
                if (n / i != i) {
                    divisors[count++] = n / i;
                }
            }
        }
        
        Array.Resize(ref divisors, count);
        Array.Sort(divisors);
        return divisors;
    }
}
