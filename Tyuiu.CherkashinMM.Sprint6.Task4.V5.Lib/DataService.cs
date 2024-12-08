using tyuiu.cources.programming.interfaces.Sprint6; 
 
namespace Tyuiu.CherkashinMM.Sprint6.Task4.V5.Lib;

public class DataService : ISprint6Task4V5
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] res = new double[Math.Abs(stopValue - startValue) + 1];
        int i = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            if ((3 * x + 1.2) == 0)
                res[i++] = 0;
            res[i++] = Math.Round(((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2, 2);
        }
        return res;
    }
} 