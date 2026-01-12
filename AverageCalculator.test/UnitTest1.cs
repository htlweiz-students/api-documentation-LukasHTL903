using lib1;

namespace AverageCalculator_test;
public class Tests_Average_Calculator
{
    
// Add Tests:

/// <summary>
/// 
/// </summary>
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
        double[] number = {2.2, 3, 7};
        test_numbs.Add(number);
        Assert.Equal(2.2, test_numbs.GetElements()[0]);
        Assert.Equal(3, test_numbs.GetElements()[1]);
        Assert.Equal(7, test_numbs.GetElements()[2]);
    }

    [Fact]
    public void Add_negative_float_array()
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
        
        Assert.Empty(test_numbs.GetElements());
    }


//Get_Average Tests:
    [Fact]
    public void Get_Average_5_numbs(){
        var test_numbs = new AverageCalculator();
        double[] numbs = {2, 3, 7, 100, 5, 27, 12.34, 27.7};
        test_numbs.Add(numbs);

        Assert.Equal(23.005, test_numbs.GetAverage());
    }

    [Fact]
    public void Get_Average_negative_numbs(){
        var test_numbs = new AverageCalculator();
        double[] numbs = {2, 3, 7, 100, -5};
        test_numbs.Add(numbs);

        Assert.Equal(21.4, test_numbs.GetAverage());
    }

    [Fact]
    public void Get_Average_empty_array(){
        var test_numbs = new AverageCalculator();
        double[] numbs = {};
        test_numbs.Add(numbs);

        Assert.Equal(0, test_numbs.GetAverage());
    }


// GetElements_tests:
    [Fact]
    public void GetElements_5_positiv_numbs(){
        var test_numbs = new AverageCalculator();
        double[] numbs = {2, 3, 2.75, 20};
        test_numbs.Add(numbs);

        Assert.Equal(2, test_numbs.GetElements()[0]);
        Assert.Equal(3, test_numbs.GetElements()[1]);
        Assert.Equal(2.75, test_numbs.GetElements()[2]);
        Assert.Equal(20, test_numbs.GetElements()[3]);
    }

        [Fact]
    public void GetElements_5_mixed_numbs(){
        var test_numbs = new AverageCalculator();
        double[] numbs = {2, -3, 2.75, -20};
        test_numbs.Add(numbs);

        Assert.Equal(2, test_numbs.GetElements()[0]);
        Assert.Equal(-3, test_numbs.GetElements()[1]);
        Assert.Equal(2.75, test_numbs.GetElements()[2]);
        Assert.Equal(-20, test_numbs.GetElements()[3]);
    }

        [Fact]
    public void GetElements_no_numbs(){
        var test_numbs = new AverageCalculator();
        double[] numbs = {};
        test_numbs.Add(numbs);

        Assert.Empty(test_numbs.GetElements());
    }
    
}