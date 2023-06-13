using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        string [] arr = my_string.Split('a','e','i','o','u');
        for(int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }
            
        return answer;
    }
}