public class Solution {
    public int CountOdds(int low, int high) {
            double tempNum=(high-low)/2;
            int oddNumbers=(int)Math.Round(tempNum);
            if(low%2!=0||high%2!=0)
            {
                oddNumbers+=1;
            }
            return oddNumbers;
    }
}