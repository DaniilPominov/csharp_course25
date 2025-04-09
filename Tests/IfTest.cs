using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.TestProject1;

[TestClass]
public class IfTest:BaseMathTest
{

    [TestMethod]
    public void TestMethod1()
    {
        int A = 1,B = 2, C = 3;
        Assert.AreEqual(_math.MinimalFromTriple(A,B,C),A);
    }
}
