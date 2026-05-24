public class Solution {
    public bool ValidPalindrome(string s) {
        if(isPalindrome(s))
            return true;

        for(int i = 0; i<s.Length; i++)
        {
            string k = s.Substring(0, i) + s.Substring(i + 1);
            if(isPalindrome(k))
            return true;
            
        }
        return false;
    }
        public bool isPalindrome(string str)
        {
            int left = 0;
            int right = str.Length -1;
            while(left < right)
            {
                if(str[left] != str[right])
                    return false;

                left++;
                right--;
            }
            return true;
        }
    
}