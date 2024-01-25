public class Solution3
{
    public static int LengthOfLongestSubstring(string s)
    {
        string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        alpha = alpha.ToLower();
        int len = 0;
        for(int i = 0; i < s.Length;i++)
        {
            if (alpha.Contains(s[i]))
            {
                len = s.Length;
            }
        }
        
        return len;
    }
}
