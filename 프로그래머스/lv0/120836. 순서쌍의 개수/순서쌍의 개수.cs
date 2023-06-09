using System;

public class Solution {
    public int solution(int n) {
        int count = 0;

        // Check for pairs where the product is equal to n
        for (int i = 1; i <= Math.Sqrt(n); i++) {
            if (n % i == 0) {
                count++;
                // If i is not the square root of n, there is an additional pair with the quotient n/i
                if (i != n / i) {
                    count++;
                }
            }
        }

        return count;
    }
}
