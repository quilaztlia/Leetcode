using Review;

public class Array_Review_Test{

    [Fact]
    public void Test_CopyArray(){
        var review = new Array_Review();

        review.AsignArray();
        
        review.CopyArray();
    }
}