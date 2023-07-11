using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        //모든원소들의 곱
        int mul1 = num_list.Sum() * num_list.Sum();
        var mul2 = num_list.Aggregate((num1,num2) => num1 * num2);     
        return mul2 < mul1 ? 1: 0;
    }
}