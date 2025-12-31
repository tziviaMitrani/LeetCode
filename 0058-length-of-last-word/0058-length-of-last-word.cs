

public class Solution {
    public int LengthOfLastWord(string s) {
      string str= s.TrimEnd();
      int ans=str.Length - str.LastIndexOf(" ")-1;
      return ans; 
   }
}