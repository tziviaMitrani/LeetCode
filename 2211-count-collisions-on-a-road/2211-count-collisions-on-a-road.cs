public class Solution {
    public int CountCollisions(string directions) {
        int arrLength=directions.Length;
        int index=0,sum=0;
        while(arrLength >0 && directions[arrLength-1]=='R'){
            arrLength--;
        }
        while(index<arrLength && directions[index]=='L') {
            index++;
        }
        for(int i=index;i<arrLength;i++){
            if(directions[i]=='L'||directions[i]=='R'){
                sum++;
            }
       }
       return sum;
    }
}