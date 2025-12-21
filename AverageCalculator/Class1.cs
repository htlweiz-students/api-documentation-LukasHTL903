namespace lib1;
public class AverageCalculator
{
    private double[] value = new double[sizeof(double)];
    private Int64 count;

    public AverageCalculator()
    {
        this.count = 0;
    }


    public void Add(double number)
    {
        this.value[this.count] = number;
        this.count++;
    }

    public void Add(double[] number)
    {
        if (number.Length != 0)
        {
            for (int count = 0; count < number.Length; count++)
            {
                Add(number[count]);
            }
        }
    }

    public double GetAverage()
    {
        if (this.count != 0)
        {
            double sum = 0;
            for (int count = 0; count < this.count; count++)
            {
                sum += this.value[count];
            }


            double average = sum / this.count;
            return average;
        }
        else
        {
            return 0;
        }

    }

    public double[] GetElements()
    {
        if (count == 0)
        {
            return Array.Empty<double>();
        }
        else
        {
            return this.value;
        }
    }
}
