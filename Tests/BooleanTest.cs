using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.TestProject1;

[TestClass]
public class BooleanTest:BaseMathTest
{

    [TestMethod]
    public void TestMethod1()
    {
        int A = 1,B = 2, C = 3;

        Assert.IsTrue(_math.CompareTriple(A,B,C));
    }
}
