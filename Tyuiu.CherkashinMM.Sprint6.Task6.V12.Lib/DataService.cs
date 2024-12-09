using tyuiu.cources.programming.interfaces.Sprint6; 
 
namespace Tyuiu.CherkashinMM.Sprint6.Task6.V12.Lib;

public class DataService : ISprint6Task6V12
{
    public string CollectTextFromFile(string str, string path)
    {
        string res = "";
        string[] text = File.ReadAllText(path).Replace("\n", " ").Split(" ");

        foreach (string s in text)
        {
            if(s.Contains(str))
                res += s + " ";
        }

        return res.Substring(0, res.Length - 1);
    }
} 
