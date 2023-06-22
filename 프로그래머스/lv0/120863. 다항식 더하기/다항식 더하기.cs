public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        int xNum = 0, num = 0;
        string[] str = polynomial.Split(" ");

        for (int i = 0; i < str.Length; i += 2) {
            if (str[i].Contains("x"))
                xNum += str[i].Replace("x", string.Empty) == "" ? 1 : int.Parse(str[i].Replace("x", string.Empty));
            else
                num += int.Parse(str[i]);
        }

        if (num == 0)
            answer = xNum == 1 ? "x" : xNum.ToString() + "x";
        else
            answer = xNum == 0 ? num.ToString() : xNum == 1 ? "x + " + num.ToString() : xNum.ToString() + "x + " + num.ToString();

        return answer;
    }
}
