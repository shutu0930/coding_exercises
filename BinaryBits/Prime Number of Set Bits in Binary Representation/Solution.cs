public class Solution {
    public int CountPrimeSetBits(int L, int R) {
        
        int primeCount = 0;
        for(int i=L; i<=R;i++)
        {
            string binaryStr = ConvertToBinary(i);
            int bitCount = CountBitSets(binaryStr);
            if(IsAPrime(bitCount))
            {
                primeCount++;
            }
        }
        
        return primeCount;
    }
    
    public int CountBitSets(string str)
    {
        int count=0;
        for(int i=0;i<str.Length;i++)
        {
            if(str[i]=='1')
            {
                count++;
            }
        }
        
        return count;
    }
    
    public bool IsAPrime(int num)
    {
        if(num ==1)
        {
            return false;
        }
        if(num==2)
        {
            return true;
        }
        for(int i=2;i<=Math.Sqrt(num);i++)
        {
            if(num%i==0)
            {
                return false;
            }
        }
        
        return true;
    }
    
    public string ConvertToBinary(int num)
    {
        
        Stack res = new Stack();
        
        int temp;
        while(num!=0)
        {
            temp=num%2;
            res.Push(temp);
            num=num/2;
            
            
        }
        string binaryStr = "";
        int size = res.Count;
        for(int i=0; i<size;i++)
        {
            binaryStr+=res.Pop();
        }
        return binaryStr;
    }
    
    
}