using tyuiu.cources.programming.interfaces.Sprint6; 
 
namespace Tyuiu.CherkashinMM.Sprint6.Task5.V15.Lib;

public class DataService : ISprint6Task5V15
{
    public double[] LoadFromDataFile(string path)
    {
        string[] file = File.ReadAllLines(path);
        double[] res = new double[file.Length];
        for(int i = 0; i < file.Length; i++)
            res[i] = Math.Round(Convert.ToDouble(file[i]), 3);
        
        res = res.Where(val => val > 2 && val < 7).ToArray();
        return res;
    }
} 
