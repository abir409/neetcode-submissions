public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
    

    while(left < right)
    {
        while(left < right && !IsAlphaNumeric(s[left])) left++;

        while(left < right && !IsAlphaNumeric(s[right])) right--;

        if(char.ToLower(s[left]) != char.ToLower(s[right]))
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
    }
    private bool IsAlphaNumeric(char c)
    {
        return (c >= 'A' && c <= 'Z' ||
                c >= 'a' && c <='z' ||
                c >= '0' && c <= '9');
    }
}