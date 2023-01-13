public class Puissance_TEst
{

[Fact]
    public void Test_1()
    {
        var solution = new Program();
        uint puissance = 46;
        var result = solution.Calcul(puissance);

        Assert.Equal(10, (int)result);
    }

    
[Fact]
    public void Test_2()
    {
        var solution = new Program();
        uint puissance = 108;
        var result = solution.Calcul(puissance);

        Assert.Equal(2, (int)result);
    }

    
    [Fact]
    public void Test_3()
    {
        var solution = new Program();
        uint puissance = 19;
        var result = solution.Calcul(puissance);

        Assert.Equal(15, (int)result);
    }
}