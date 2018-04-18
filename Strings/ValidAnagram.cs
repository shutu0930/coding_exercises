public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s == null || t == null)
        {
            return false;
        }

        char[] strs = s.ToCharArray();
        char[] tars = t.ToCharArray();

        Array.Sort(strs);
        Array.Sort(tars);

        string str = new string(strs);
        string tar = new string(tars);

        if (str == tar)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}