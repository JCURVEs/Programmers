using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        return Array.IndexOf(num_list,num_list.FirstOrDefault(n=> n<0));
    }
}