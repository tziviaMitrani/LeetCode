public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        Array.Sort(capacity);
        Array.Reverse(capacity);
        int numApple=0;
        int numCapacity=0;
        for(int i=0;i<apple.Length;i++){
            numApple=numApple+apple[i];
        }
        for (int i=0;i<capacity.Length;i++) {
            numApple=numApple-capacity[i];
            if(numApple<=0) {
                numCapacity=i+1;
                break;
            }
        }
        return numCapacity;
    }
}