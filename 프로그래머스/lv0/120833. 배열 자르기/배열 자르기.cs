using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int length = num2 - num1 + 1; // Calculate the length of the new array
        int[] answer = new int[length];
        
        for (int i = 0; i < length; i++) {
            answer[i] = numbers[num1 + i]; // Copy elements from the specified range
        }
        
        return answer;
    }
}
