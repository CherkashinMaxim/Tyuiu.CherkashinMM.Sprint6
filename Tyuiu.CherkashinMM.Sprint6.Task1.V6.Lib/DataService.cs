using tyuiu.cources.programming.interfaces.Sprint6; 
 
namespace Tyuiu.CherkashinMM.Sprint6.Task1.V6.Lib;

public class DataService : ISprint6Task1V6
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] res = new double[Math.Abs(stopValue - startValue) + 1];
        int i = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            if ((3 * x - 1) == 0)
                res[i++] = 0;
            res[i++] = Math.Round(((Math.Sin(x) - 2 * x) / (3 * x - 1)) + Math.Sin(x) - 3 * x + 2, 2);
        }
        return res;
    }
} 
