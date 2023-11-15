using System.Runtime.CompilerServices;

namespace Codility_FrogRiverOne
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int X, int[] A)
        {
            int N = A.Length;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE &&
                X >= RANGE_LOWEST_VALUE && X <= RANGE_HIGHEST_VALUE) 
            {
                HashSet<int> positions = new HashSet<int>();
                for (int i = 0; i < N; i++)
                {
                    positions.Add(A[i]);
                    // Check if all positions are covered
                    if (positions.Count == X)
                        return i; // Return the earliest time when all positions are covered
                }

                return -1; // If the frog is never able to jump to the other side
            }
            
            return -2;
        }
    }
}
