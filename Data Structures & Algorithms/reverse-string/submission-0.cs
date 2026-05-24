public class Solution {
    public void ReverseString(char[] s) {
        char[] result = new char[s.Length];
        int count =0;
        for(int i = s.Length-1; i>= 0; i--)
        {
            result[count] = s[i];
            count++;
        }
        for(int i = 0; i<s.Length; i++)
        {
            s[i] = result[i];
        }
    }
}