/*
Intuition and Approach

For each number from L to R, let's find out how many set bits
it has. If that number is 2, 3, 5, 7, 11, 13, 17, or 19,
then we add one to our count. We only need primes up to 19 because R \leq 10^6 < 2^{20}R≤10^6<2^20.
*/

class Solution {
    public int countPrimeSetBits(int L, int R) {
        int ans = 0;
        for (int x = L; x <= R; ++x)
            if (isSmallPrime(Integer.bitCount(x)))
                ans++;
        return ans;
    }
    public boolean isSmallPrime(int x) {
        return (x == 2 || x == 3 || x == 5 || x == 7 ||
                x == 11 || x == 13 || x == 17 || x == 19);
    }
}
