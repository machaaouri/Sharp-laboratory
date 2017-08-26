namespace SortAndSearch
{
    public class SortAndSearch
    {

        // Given 2 arrays sorted , write method to merge B into A in sorted order.
        public static void merge(int[] A,int M,int[] B)
        {
            int k = M + B.Length - 1;
            int i = M - 1; // last element of A
            int j = B.Length - 1; // last element of B

            while(i>= 0  && j >= 0)
            {
                if(A[i] > B[j])
                {
                    A[k--] = A[i--];
                }
                else
                {
                    A[k--] = B[j--];
                }
            }
            while(j>=0)
            {
                A[k--] = B[j--];
            }
        }

    }
}
