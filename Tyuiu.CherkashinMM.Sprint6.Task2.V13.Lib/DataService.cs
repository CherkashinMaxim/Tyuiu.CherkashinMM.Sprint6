using tyuiu.cources.programming.interfaces.Sprint6; 
 
namespace Tyuiu.CherkashinMM.Sprint6.Task2.V13.Lib;

public class DataService : ISprint6Task2V13
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] res = new double[Math.Abs(stopValue - startValue) + 1];
        int i = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            res[i++] = Math.Round(Math.Sin(x) + (2 * x / 3) - Math.Cos(x) * 4 * x, 2);
        }
        return res;
    }
} 
