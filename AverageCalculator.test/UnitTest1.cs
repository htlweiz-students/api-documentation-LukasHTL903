using lib1;

namespace AverageCalculator_test;
public class UnitTest1
{
    
// Add Tests:
    [Fact]
    public void Add_float(){
        var test_numbs = new AverageCalculator();
        double number = 7;
        test_numbs.Add(number);
        Assert.Equal(7, test_numbs.GetElements()[0]);
    }

    [Fact]
    public void Add_float_array(){
        var test_numbs = new AverageCalculator();
        double[] number = {2, 3, 7};
        test_numbs.Add(number);
        Assert.Equal(2, test_numbs.GetElements()[0]);
        Assert.Equal(3, test_numbs.GetElements()[1]);
        Assert.Equal(7, test_numbs.GetElements()[2]);
    }

    [Fact]
    public void Add_negative_floats()
    {
        var test_numbs = new AverageCalculator();
        double[] number = {-2, 3, -7};
        test_numbs.Add(number);
        Assert.Equal(-2, test_numbs.GetElements()[0]);
        Assert.Equal(3, test_numbs.GetElements()[1]);
        Assert.Equal(-7, test_numbs.GetElements()[2]);
    }


    [Fact]
    public void Add_empty_float()
    {
        var test_numbs = new AverageCalculator();
        double[] empty = {};
        test_numbs.Add(empty);
        test_numbs.Add(7f);
        
        Assert.Equal(7, test_numbs.GetElements()[0]);
    }


//Get_Average Tests:

    [Fact]
    public void Get_Average_5_numbs(){
        var test_numbs = new AverageCalculator();
        double[] numbs = {2, 3, 7, 100, -5};
        test_numbs.Add(numbs);

        Assert.Equal(21.4 ,test_numbs.GetAverage());
    }
}