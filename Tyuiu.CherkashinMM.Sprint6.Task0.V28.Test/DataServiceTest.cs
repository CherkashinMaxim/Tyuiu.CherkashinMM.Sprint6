using Tyuiu.CherkashinMM.Sprint6.Task0.V28.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint6.Task0.V28.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   {
        DataService ds = new DataService();
        int x = 3;
        double wait = 169.89;
        Assert.AreEqual(wait, ds.Calculate(x));

    }
} 
