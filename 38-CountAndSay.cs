public class Solution {
    public string CountAndSay(int n) {
       if(n==1) return "1";
        string result ="1";
        for(int i=1;i<n;i++){
            string tmp="";
            int count=1;
            for(int j=1;j<result.Length;j++){
                if(result[j]==result[j-1]){
                        count++;
                    }
                else{
                    tmp=tmp+count.ToString()+result[j-1];
                    count=1;
                }
            }
            result=tmp+count.ToString()+result[result.Length-1];   
            }
        return result;
    }
}
