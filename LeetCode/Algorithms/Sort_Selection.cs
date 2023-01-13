/* SELECTION SORT A[i]:
        For i from 0 to n-1     
            1.Find the smallest in A[i] toA[n-1]
            2.Swap(smallest with A[i])                    
*/
public class Sort_Selection
{
    public int[] SelectionSort(int[] A)
    {
        int n = A.Length;
        for (int i = 0; i < n; i++)
        {
            var smallestIndex = FindSmallestIndex(A, i, n - 1);
            Swap(A, smallestIndex, i);
        }
        return A;
    }

    int FindSmallestIndex(int[] A, int start, int end)
    {
        var smallestValue = A[start];
        int smallestIndex = start;
        for (int j = start+1; j <end; j++)
            if (A[j] < smallestValue)
                smallestIndex = j;

        return smallestIndex;
    }

    void Swap(int[] A, int smallestIndex, int index)
    {
        if(A[smallestIndex] < A[index]){
            int swap = A[index];
            A[index] = A[smallestIndex];
            A[index] = swap;
        }
    }
}

/*
  
//By reference ??
int FindSmallestIndex_WithLinq(int[] A, int start, int end){
    return A.
}
*/

