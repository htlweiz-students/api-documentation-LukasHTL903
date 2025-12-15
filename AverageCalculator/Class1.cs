namespace AverageCalculator_nspc;
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
        this.value[count] = number;
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

    public double getAverage(){
        double sum = 0;
        for (int count = 0; count < this.count; count ++){
            sum += this.value[count];
        }

        double average = sum / this.count;

        return average;
    }

    public double[] GetElements()
    {
        return value;
    }
}
