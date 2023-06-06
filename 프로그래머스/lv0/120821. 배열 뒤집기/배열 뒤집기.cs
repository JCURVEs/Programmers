using System;

public class Solution{
    public int[] solution(int[]num_list){
        int length = num_list.Length;
        int[] reversedList = new int [length];
        
        for( int i = 0; i < length; i++)
        {
            reversedList[i] = num_list[length - 1 - i];
        }
        return reversedList;
    }
}

