using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests;

[TestClass]
public class ProcTest:BaseMathTest
{
    [TestMethod]
    public void RootCountTest0()
    {
        double A = 1;
        double B = 1;
        double C = 1;
        Assert.AreEqual(_math.RootCount(A,B,C),0);
    }
    [TestMethod]
    public void RootCountTest1()
    {
        double A = 1;
        double B = 0;
        double C = 0;
        Assert.AreEqual(_math.RootCount(A,B,C),1);
    }
    [TestMethod]
    public void RootCountTest2()
    {
        double A = 1;
        double B = 1;
        double C = -1;
        Assert.AreEqual(_math.RootCount(A,B,C),2);
    }
}
