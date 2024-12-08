using Tyuiu.CherkashinMM.Sprint6.Task4.V5.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint6.Task4.V5.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();
        double[] wait = [70.14, 55.21, 41.05, 27.96, 15.48, 1, -13.06, -28.16, -42.96, -56.77, -69.83];
        CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, 5));
   } 
} 
