using Tyuiu.CherkashinMM.Sprint6.Task1.V6.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint6.Task1.V6.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   {
        DataService ds = new DataService();
        double[] wait = [17.27, 14.08, 10.27, 6.65, 3.87, 2, -0.74, -3.71, -7.59, -11.55, -14.74];
        CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, 5));
   } 
} 
