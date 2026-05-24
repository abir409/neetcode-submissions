public class Solution {
    public bool IsPalindrome(string s) {
        string reversed = "";

        foreach(char c in s)
        {
            if(char.IsLetterOrDigit(c))
            {
                reversed += char.ToLower(c);
            }
        }
        return reversed == new string(reversed.Reverse().ToArray());

    }
}
