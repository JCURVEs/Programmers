using System;

public class Example
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            
            if (char.IsLower(c))
                result += char.ToUpper(c);
            else if (char.IsUpper(c))
                result += char.ToLower(c);
            else
                result += c;
        }

        Console.WriteLine(result);
    }
}