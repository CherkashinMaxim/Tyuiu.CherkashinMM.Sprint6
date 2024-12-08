using Tyuiu.CherkashinMM.Sprint6.Task5.V15.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint6.Task5.V15.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V15.txt");
        double[] wait = [3.36, 4.13];
        CollectionAssert.AreEqual(wait, ds.LoadFromDataFile(path));
   } 
} 
