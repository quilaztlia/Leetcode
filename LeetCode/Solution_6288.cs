public class DataStream {   

private int[] _stream;
private int _total;
private int _value;
    public DataStream(int value, int k) {
        int total = k; 
         _stream = new int[k]; 
         _total = k;
    }
    
    public bool Consec(int num) {
        return false;
    }

    /**
 * Your DataStream object will be instantiated and called as such:
 * DataStream obj = new DataStream(value, k);
 * bool param_1 = obj.Consec(num);
 */
}