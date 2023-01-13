/*BUBBLE SORT A[i]: 
            Loop in pairs A[i], A[i+1]
                UNTIL (Ordered)
                OR n
            Ordered = true;

            If A[i] > A[i+1]
                Swap()
                Flag(!Ordered)            
*/
public class BubbleSort
{

    public int[] Bubble_Sort_Asc(int[] A)
    {
        bool isOrdered=false;
        int j=0, length=A.Length;        
        while(!isOrdered && j<length){
            isOrdered=true;

            for(int i=0; i<length-1; i++){                
                if(A[i] > A[i+1]){
                    isOrdered=false;
                    Swap(A, i+1, i);
                }
            }
        }
        return A;
    }

    private int[] Swap(int[] A, int index_min, int index_max){
        var swap = A[index_min];
        A[index_min] = A[index_max];
        A[index_max] = swap;

        return A;
    }


}