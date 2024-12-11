using tyuiu.cources.programming.interfaces.Sprint6; 
 
namespace Tyuiu.CherkashinMM.Sprint6.Task7.V29.Lib;

public class DataService : ISprint6Task7V29
{
    public int[,] GetMatrix(string path)
    {
        string[] file = File.ReadAllLines(path);
        int[,] matrix = new int[file.Length, file[0].Count(f => f == ';') + 1];

        for (int i = 0; i < file.Length; i++)
        {
            string[] line = file[i].Split(';');

            for (int j = 0; j < line.Length; j++)
            {
                int num = Convert.ToInt32(line[j]);
                if (i == 4 && num >= -5 && num <= 10)
                {
                    matrix[i, j] = 99;
                    continue;
                }
                matrix[i,j] = num;
            }
        }

        return matrix;
    }
} 
