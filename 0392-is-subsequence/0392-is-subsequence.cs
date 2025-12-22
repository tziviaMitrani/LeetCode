
public class Solution {
    public bool IsSubsequence(string s, string t) {
        int tempInt=0;
        for(int i=0;i<s.Length;i++) {
            if(i>0&&s[i]==s[i-1]){
                tempInt++;
            }
            tempInt=t.IndexOf(s[i], tempInt);
            if(tempInt==-1) {
               return false;
            }
        }
        return true;
    }
}
