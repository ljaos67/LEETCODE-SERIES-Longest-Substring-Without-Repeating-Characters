public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        string tmp = "";
        int max = 0;
        //if(s.Length == 1) return 1;
        for(int i = 0; i < s.Length; i++)
        {
            if(tmp.Contains(s[i]))
            {
                while(tmp.Contains(s[i]))
                {
                    tmp = (tmp.Length > 1 ? tmp.Substring(1) : "");
                }
            }
            tmp += s[i];
            max = (max > tmp.Length ? max : tmp.Length);
        }
        return max;
    }
}
