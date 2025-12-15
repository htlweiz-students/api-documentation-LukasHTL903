namespace AverageCalculator_nspc;
public class AverageCalculator
{
    private double[] value = new double[sizeof(double)];
    private Int64 pointer;

    public AverageCalculator()
    {
        this.pointer = 0;
    }


    public void Add(double number)
    {
        this.value[pointer] = number;
        this.pointer++;
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
        for (int count = 0; count < this.pointer; count ++){
            sum += this.value[count];
        }

        double average = sum / this.pointer;

        return average;
    }

    public double[] GetElements()
    {
        return value;
    }
}
