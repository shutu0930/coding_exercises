public class Solution {
    public string ReverseString(string s) {
        
        if(s==null)
        {
            return null;
        }
        char[] strs = s.ToCharArray();
        char temp;
        for(int i=0;i<strs.Length/2;i++)
        {
            temp = strs[i];
            strs[i]= strs[strs.Length-i-1];
            strs[strs.Length-i-1] = temp;
        }
        return new string(strs);
    }
}