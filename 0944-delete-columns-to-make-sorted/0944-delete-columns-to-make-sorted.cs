public class Solution {
    public int MinDeletionSize(string[] strs) {
       int sumStr= strs.Length;
       int sumDel=0;
       for(int i=0;i<strs[0].Length;i++) {
        for(int j=0;j<sumStr-1;j++)
        {
            if(strs[j][i]>strs[j+1][i]){
                  sumDel++;
                  break;
            }

        }
        // int j=0;
        // while(j!=sumStr-1&&strs[j][i]<=strs[j+1][i]) {
        //     j++;
        // }
        // if(j!=sumStr-1) {
        //     sumDel++;
        // }
       }
       return sumDel;
    }
}